using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Group_11_Project_LIMS
{
    public partial class AddWorkRequestForm : Form
    {
        // variables for the connection string, command and reader
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        public AddWorkRequestForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // checks if all the input is valid, and writes new work request to the database table
            if (inputIsValid())
            {
                try
                {
                    myConn = new SqlConnection(connString);

                    myConn.Open();

                    myCommand = new SqlCommand("EXECUTE AddWorkRequest @Client_ID, @Employee_ID, @Analytical_test_description, @Date_work_received, @Date_work_due, @Invoiced_YN", myConn);

                    myCommand.Parameters.Add("@Client_ID", SqlDbType.Int).Value = acquireClientID();
                    myCommand.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = acquireEmployeeID();
                    myCommand.Parameters.Add("@Analytical_test_description", SqlDbType.NVarChar, 50).Value = txtTestDescription.Text.Trim();
                    myCommand.Parameters.Add("@Date_work_received", SqlDbType.Date).Value = DateTime.Today.Date;
                    myCommand.Parameters.Add("@Date_work_due", SqlDbType.Date).Value = DateTime.Today.Date.AddDays(14);
                    myCommand.Parameters.Add("@Invoiced_YN", SqlDbType.Bit).Value = false;

                    myCommand.ExecuteNonQuery();

                    myConn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Work Request successfully added", "Task Successful");
                this.Close();
            }
        }

        private void AddWorkRequestForm_Load(object sender, EventArgs e)
        {
            populateClientList();
            populateEmployeeList();
        }

        // method that reads records from the Client database table, and populates the cmbClient combobox with values
        private void populateClientList()
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectAllClients", myConn);

                myReader = myCommand.ExecuteReader();

                cmbClient.Items.Clear();

                while (myReader.Read())
                {
                    string nextEntry = myReader.GetValue(0) + " " + myReader.GetValue(1) + " " + myReader.GetValue(2);
                    cmbClient.Items.Add(nextEntry);
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method that reads records from the Employee database table, and populates the cmbEmployee combobox with values
        private void populateEmployeeList()
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectAllEmployees", myConn);

                myReader = myCommand.ExecuteReader();

                cmbEmployee.Items.Clear();

                while (myReader.Read())
                {
                    string nextEntry = myReader.GetValue(0) + " " + myReader.GetValue(1) + " " + myReader.GetValue(2);
                    cmbEmployee.Items.Add(nextEntry);
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method that obtains the ID of the currently selected client, and returns it
        private int acquireClientID()
        {
            int selectedID = 0;

            if (cmbClient.Text != "")
            {
                String selectedItem = cmbClient.Text;
                String[] splitValues = selectedItem.Split(' ');
                selectedID = int.Parse(splitValues[0]);
            }
            else
            {
                MessageBox.Show("Please select a client from the list");
                return selectedID;
            }

            return selectedID;
        }

        // method that obtains the ID of the currently selected employee, and returns it
        private int acquireEmployeeID()
        {
            int selectedID = 0;

            if (cmbEmployee.Text != "")
            {
                String selectedItem = cmbEmployee.Text;
                String[] splitValues = selectedItem.Split(' ');
                selectedID = int.Parse(splitValues[0]);
            }
            else
            {
                MessageBox.Show("Please select an employee from the list");
                return selectedID;
            }

            return selectedID;
        }

        private bool inputIsValid()
        {
            bool inputValid = false;

            if (cmbClient.SelectedIndex != -1)
            {
                if (cmbEmployee.SelectedIndex != -1)
                {
                    if (txtTestDescription.Text != "")
                    {
                        inputValid = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter an analytical test description", "Input Error");
                        txtTestDescription.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an employee from the list", "Input Error");
                    cmbEmployee.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select a client from the list", "Input Error");
                cmbClient.Focus();
            }

            return inputValid;
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a new work request, select a client and employee from the names provided in the lists," +
                         " enter a description of the analytical test, and click the \"Add\" button." +
                         "\nOtherwise, to go back without making any changes, click on the \"Cancel\" button", "Help");
        }
    }
}
