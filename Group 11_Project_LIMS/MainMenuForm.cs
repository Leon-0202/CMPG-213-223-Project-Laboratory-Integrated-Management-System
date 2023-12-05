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
    public partial class MainMenuForm : Form
    {
        string username;
        bool admin;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        // parameterized constructor
        public MainMenuForm(string username, bool admin)
        {
            InitializeComponent();

            this.username = username;
            this.admin = admin;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            this.Hide();
            employeesForm.ShowDialog();
            this.Show();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            this.Hide();
            clientsForm.ShowDialog();
            this.Show();
        }

        private void btnWorkRequests_Click(object sender, EventArgs e)
        {
            WorkRequestForm workRequestForm = new WorkRequestForm();
            this.Hide();
            workRequestForm.ShowDialog();
            this.Show();
        }

        private void btnInvoicesPayments_Click(object sender, EventArgs e)
        {
            InvoicesPaymentsForm invoicesPaymentsForm = new InvoicesPaymentsForm();
            this.Hide();
            invoicesPaymentsForm.ShowDialog();
            this.Show();
        }

        private void tsLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // sets the functionality of the form according to the user type
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            lblUserDisplay.Text = username;

            if (admin)
            {
                lblRoleDisplay.Text = "Administrator";
            }
            else
            {
                lblRoleDisplay.Text = "Lab Technician";
                btnEmployees.Enabled = false;
                btnClients.Enabled = false;
            }
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To look at work requests, click on the \"Work Requests\" button" +
                            "To look at clients, click on the \"Clients\" button" +
                            "To look at employees, click on the \"Employees\" button" +
                            "To look at invoices and payments, click on the \"Invoices and Payments\" button" +
                            "\nOtherwise, to log out, select \"Account\" from the menu and click on \"Log Out\"", "Help");
        }
    }
}
