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

namespace Group_11_Project_LIMS
{
    public partial class EditWorkRequestForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        int selectedID;

        public EditWorkRequestForm()
        {
            InitializeComponent();
        }

        public EditWorkRequestForm(int selectedID)
        {
            InitializeComponent();

            this.selectedID = selectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (inputIsValid())
            {
                try
                {
                    myConn.Open();

                    myCommand = new SqlCommand("EXECUTE UpdateWorkRequest @Work_request_ID, @Client_ID, @Employee_ID, @Analytical_test_description", myConn);

                    myCommand.Parameters.Add("@Work_request_ID", SqlDbType.Int).Value = selectedID;
                    myCommand.Parameters.Add("@Client_ID", SqlDbType.Int).Value = acquireClientID();
                    myCommand.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = acquireEmployeeID();
                    myCommand.Parameters.Add("@Analytical_test_description", SqlDbType.NVarChar, 50).Value = txtTestDescription.Text.Trim();

                    myCommand.ExecuteNonQuery();

                    myConn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Work Request successfully updated", "Task Successful");
                this.Close();
            }
        }

        private void EditWorkRequestForm_Load(object sender, EventArgs e)
        {
            populateClientList();
            populateEmployeeList();

            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSingleWorkRequest @Work_request_ID", myConn);

                myCommand.Parameters.Add("@Work_request_ID", SqlDbType.Int).Value = selectedID;

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    // cleans up output
                    string dateReceived = myReader.GetValue(4).ToString();
                    String[] dateReceivedSplit = dateReceived.Split(' ');
                    dateReceived = dateReceivedSplit[0];

                    // cleans up output
                    string dateDue = myReader.GetValue(5).ToString();
                    String[] dateDueSplit = dateDue.Split(' ');
                    dateDue = dateDueSplit[0];

                    string invoiced = myReader.GetValue(6).ToString();

                    lblWRNoDisplay.Text = myReader.GetValue(0).ToString();
                    lblSelectClientPrevious.Text = "Was: " + myReader.GetValue(1).ToString();
                    lblSelectEmployeePrevious.Text = "Was: " + myReader.GetValue(2).ToString();
                    txtTestDescription.Text = myReader.GetValue(3).ToString();
                    lblDateReceivedDisplay.Text = dateReceived;
                    lblDateDueDisplay.Text = dateDue;
                    lblInvoicedDisplay.Text = (invoiced == "True" ? "Yes" : "No");
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
            MessageBox.Show("To edit the existing work request, enter all the required information of the work request and click the \"Apply Changes\" button." +
                          "\nThe client and employee have to be selected from the lists." +
                "          \nOtherwise, to go back without making any changes, click on the \"Cancel\" button", "Help");
        }
    }
}
