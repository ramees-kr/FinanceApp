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
    public partial class AddTransactionForm : Form
    {
        private ASSN4DBContext _dbContext;
        private User _currentUser;

        public AddTransactionForm(ASSN4DBContext dbContext, User currentUser)
        {
            this._dbContext = dbContext;
            this._currentUser = currentUser;

            InitializeComponent();

            // Set the Account ID text box to the current user's account ID
            textBoxAccountID.Text = _dbContext.Accounts
                                            .Where(a => a.UserId == _currentUser.Id)
                                            .Select(a => a.AccountId)
                                            .FirstOrDefault()
                                            .ToString();

            dateTimePickerTransactionDate.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

                // Get the AccountId of the current user
                int accountId = _dbContext.Accounts
                                        .Where(a => a.UserId == _currentUser.Id)
                                        .Select(a => a.AccountId)
                                        .FirstOrDefault();

                // Get the description from the text box
                string description = textBoxDescription.Text;

                //Validate the date
                if (dateTimePickerTransactionDate.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Transaction date cannot be in the future.");
                    return;
                }

                // Create a new TransactionHistory object
                TransactionHistory newTransaction = new TransactionHistory
                {
                    AccountId = accountId,
                    TransactionDate = DateTime.Now, // Set the current date and time as transaction date
                    Amount = (decimal?)amount,
                    Description = description
                };

               //Ask for confirmation before saving the transaction
               DialogResult result = MessageBox.Show($"{newTransaction.ToString()}\n\n Are you sure you want to save the transaction?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    SaveTransaction(newTransaction);
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
            // Add the new transaction to the TransactionHistories DbSet
            _dbContext.TransactionHistories.Add(newTransaction);

            // Save changes to the database
            _dbContext.SaveChanges();

            // Display a success message
            MessageBox.Show("Transaction saved successfully.");
        }
    }
}
