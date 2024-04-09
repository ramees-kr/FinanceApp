using Assignment4.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4.UI
{
    public partial class UpdateTransactionForm : Form
    {
        private ASSN4DBContext _dbContext;
        private TransactionHistory selectedTransaction;
        private User _currentUser;

        public UpdateTransactionForm(ASSN4DBContext dbContext, TransactionHistory selectedTransaction, User currentUser)
        {
            this._dbContext = dbContext;
            this.selectedTransaction = selectedTransaction;
            this._currentUser = currentUser;

            InitializeComponent();
            UpdateDefaultData();
        }

        private void UpdateDefaultData()
        {
            // Set the Account ID text box to the current user's account ID
            textBoxAccountID.Text = _dbContext.Accounts
                                            .Where(a => a.UserId == _currentUser.Id)
                                            .Select(a => a.AccountId)
                                            .FirstOrDefault()
                                            .ToString();

            textBoxTransactionID.Text = _dbContext.TransactionHistories
                                            .Where(th => th.TransactionId == selectedTransaction.TransactionId)
                                            .Select(th => th.TransactionId)
                                            .FirstOrDefault()
                                            .ToString();

            // Set the transaction date to the selected transaction's date
            dateTimePickerTransactionDate.Value = (System.DateTime)selectedTransaction.TransactionDate;

            // Set the transaction amount to the selected transaction's amount
            textBoxAmount.Text = selectedTransaction.Amount.ToString();

            // Set the transaction description to the selected transaction's description
            textBoxDescription.Text = selectedTransaction.Description;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //validate the amount > 0 and < 10000
                if (double.TryParse(textBoxAmount.Text, out double amount))
                {
                    if (amount <= -10000 || amount >= 10000)
                    {
                        MessageBox.Show("Amount must be between -10000 and 1000.");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Invalid amount. Please enter a valid number.");
                    return;
                }

                // Get the description from the text box
                string description = textBoxDescription.Text;

                //Validate the date
                if (dateTimePickerTransactionDate.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Transaction date cannot be in the future.");
                    return;
                }

                //update the selected transaction Amount, Description and TransactionDate with the new values
                selectedTransaction.Amount = (decimal?)amount;
                selectedTransaction.Description = description;
                selectedTransaction.TransactionDate = dateTimePickerTransactionDate.Value;
                
                //Ask for confirmation before saving the transaction
                DialogResult result = MessageBox.Show($"{selectedTransaction.ToString()}\n\n Are you sure you want to save the changes?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    SaveTransaction(selectedTransaction);

                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Error occurred while saving the transaction: " + ex.Message);
            }
        }

        private void SaveTransaction(TransactionHistory newTransaction)
        {
            //update the transaction in the TransactionHistories DbSet
            _dbContext.TransactionHistories.Update(newTransaction);

            // Save changes to the database
            _dbContext.SaveChanges();

            // Display a success message
            MessageBox.Show("Transaction saved successfully.");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
