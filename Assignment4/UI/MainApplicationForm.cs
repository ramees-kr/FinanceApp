using Assignment4.Models.Entities;
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
    public partial class MainApplicationForm : Form
    {
        private readonly ASSN4DBContext _dbContext;
        private readonly User _currentUser;
        private TransactionHistory selectedTransaction;

        public MainApplicationForm(ASSN4DBContext dbContext, User currentUser)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _currentUser = currentUser;
        }

        private void DisplayAccountDetails()
        {
            var userAccount = _dbContext.Accounts.FirstOrDefault(a => a.UserId == _currentUser.Id);
            if (userAccount != null)
            {
                lblAccountType.Text = userAccount.AccountType;
                lblCurrentBalance.Text = userAccount.CurrentBalance.ToString();
            }
            else
            {
                lblAccountType.Text = "NA";
                lblCurrentBalance.Text = "NA";
            }
        }
        private void UpdateAccountBalance()
        {
            // Get the AccountId of the current user
            int accountId = _dbContext.Accounts
                                    .Where(a => a.UserId == _currentUser.Id)
                                    .Select(a => a.AccountId)
                                    .FirstOrDefault();

            if (accountId != 0)
            {
                // Get transactions for the selected accountId
                var transactionHistory = _dbContext.TransactionHistories
                                                    .Where(th => th.AccountId == accountId)
                                                    .ToList();

                // Calculate the current balance
                double currentBalance = 0;
                foreach (var transaction in transactionHistory)
                {
                    currentBalance += (double)transaction.Amount;
                }

                //MessageBox.Show("Current Balance: " + currentBalance);


                // Update the current balance in the Accounts table
                var account = _dbContext.Accounts.FirstOrDefault(a => a.AccountId == accountId);
                account.CurrentBalance = currentBalance;

                _dbContext.SaveChanges();

                lblCurrentBalance.Text = account.CurrentBalance.ToString();
            }
        }

        private void DisplayTransactionHistory()
        {
            // Get the AccountId of the current user
            int accountId = _dbContext.Accounts
                                    .Where(a => a.UserId == _currentUser.Id)
                                    .Select(a => a.AccountId)
                                    .FirstOrDefault();

            if (accountId != 0)
            {
                // Get transactions for the selected accountId
                var transactionHistory = _dbContext.TransactionHistories
                                                    .Where(th => th.AccountId == accountId)
                                                    .ToList();

                dataGridViewTransactionHistory.DataSource = transactionHistory;
            }
            else
            {
                MessageBox.Show("No transactions found for the current user.");
            }
        }

        public void updatedata()
        {

            DisplayTransactionHistory();
            DisplayAccountDetails();

            UpdateAccountBalance();
        }

        private void dataGridViewTransactionHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTransactionHistory.SelectedRows.Count > 0)
            {
                // At least one row is selected
                btnUpdateTransaction.Enabled = true;
                btnDeleteTransaction.Enabled = true;

                // Retrieve the selected transaction from the first selected row
                int transactionId = Convert.ToInt32(dataGridViewTransactionHistory.SelectedRows[0].Cells["TransactionId"].Value);
                selectedTransaction = _dbContext.TransactionHistories.FirstOrDefault(th => th.TransactionId == transactionId);
            }
            else
            {
                // No rows are selected
                btnUpdateTransaction.Enabled = false;
                btnDeleteTransaction.Enabled = false;
            }
        }

        private void MainApplicationForm_Load(object sender, EventArgs e)
        {
            updatedata();

            // No rows are selected
            btnUpdateTransaction.Enabled = false;
            btnDeleteTransaction.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the main application form and show the login form
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransactionForm = new AddTransactionForm(_dbContext, _currentUser);
            addTransactionForm.ShowDialog();

            // Refresh data after adding a new transaction
            updatedata();
        }

        private void btnUpdateTransaction_Click(object sender, EventArgs e)
        {
            // Check if a transaction is selected
            if (selectedTransaction != null)
            {
                UpdateTransactionForm updateTransactionForm = new UpdateTransactionForm(_dbContext, selectedTransaction, _currentUser);
                updateTransactionForm.ShowDialog();

                //MessageBox.Show("Transaction updated successfully. Back in Mainform");
                // Refresh data after updating the transaction
                updatedata();
            }

        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            // Check if a transaction is selected
            if (selectedTransaction != null)
            {
                // Confirm if the user wants to delete the transaction
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected transaction?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    // Delete the selected transaction
                    _dbContext.TransactionHistories.Remove(selectedTransaction);
                    _dbContext.SaveChanges();

                    // Refresh data after deleting the transaction
                    updatedata();
                }
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userAccount = _dbContext.Accounts.FirstOrDefault(a => a.UserId == _currentUser.Id);
            // Display the account and user detials
            MessageBox.Show($"User\n"+ _currentUser.GetUserDetails() + "\n\nAccount\n" + userAccount.GetAccountDetails());
        }
    }
}
