/*
CMPG 223
Group 11

Christiaan Visagie, 37332287
Leon Mostert, 20805330
Pearl Makhafola, 31453600
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_11_Project_LIMS
{
    public partial class LoginForm : Form
    {
        string adminPassword = "2222";
        string labTechPassword = "1111";

        public LoginForm()
        {
            InitializeComponent();
        }

        // logs in as either an administrator or a lab technician, according to the password used
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (inputIsValid())
            {
                string username = txtUserName.Text;
                string enteredPassword = txtPassword.Text;

                if (enteredPassword == adminPassword) 
                {
                    // calls the main menu form as an admin account
                    MainMenuForm mainMenuForm = new MainMenuForm(username, true);
                    this.Hide();
                    mainMenuForm.ShowDialog();

                    cleanupForm();
                }
                else if (enteredPassword == labTechPassword)
                {
                    // calls the main menu form as a lab tech account
                    MainMenuForm mainMenuForm = new MainMenuForm(username, false);
                    this.Hide();
                    mainMenuForm.ShowDialog();

                    cleanupForm();
                }
                else
                {
                    // promps user to enter password again
                    MessageBox.Show("The password you have entered is incorrect");
                    txtPassword.Focus();
                }
            }
        }

        // exits application
        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // checks if the input is correct and returns true or false
        private bool inputIsValid()
        {
            bool inputValid = false;

            if (txtUserName.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    inputValid = true;
                }
                else
                {
                    MessageBox.Show("Please enter a password", "Input Error");
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a username", "Input Error");
                txtUserName.Focus();
            }

            return inputValid;
        }

        // clears textboxes and resets focus
        private void cleanupForm()
        {
            this.Show();

            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }
    }
}
