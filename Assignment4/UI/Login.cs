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
    public partial class Login : Form
    {
        private readonly ASSN4DBContext _dbContext;
        private User _currentUser;
        private int loginAttemptCount;
        public Login()
        {
            InitializeComponent();
            _dbContext = new ASSN4DBContext();
            loginAttemptCount = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            try
            {
                // Check if the username and password exist in the database
                var user = _dbContext.Users.FirstOrDefault(u => u.Email == username && u.Password == password);

                if (user != null)
                {
                    _currentUser = user;

                    //Authentication successful, open main application form
                    MainApplicationForm mainForm = new MainApplicationForm(_dbContext,user);
                    mainForm.Show();
                    this.Hide();
                    MessageBox.Show("Login successful!");
                    loginAttemptCount = 0;
                }
                else
                {
                    // Increment login attempt count
                    loginAttemptCount++;

                    // Check if login attempts exceed the limit
                    if (loginAttemptCount >= 3)
                    {
                        MessageBox.Show("Too many unsuccessful login attempts. The application will now exit.");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again. Attempt " + loginAttemptCount + " of 3.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
            }
        }

    }
}
