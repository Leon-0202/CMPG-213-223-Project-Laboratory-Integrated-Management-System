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
    public partial class WorkRequestForm : Form
    {
        // variables for the connection string, command and reader
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        public WorkRequestForm()
        {
            InitializeComponent();
        }

        // opens up the AddWorkRequestForm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWorkRequestForm addWorkRequestForm = new AddWorkRequestForm();
            addWorkRequestForm.ShowDialog();
            updateList();
            txtSearch.Clear();
        }

        // opens up the EditWorkRequestForm
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // obtains the ID of the currently selected work request
            int selectedID = acquireSelectedID();

            if (selectedID != 0)
            {
                EditWorkRequestForm editWorkRequestForm = new EditWorkRequestForm(selectedID);
                editWorkRequestForm.ShowDialog();
                updateList();
                txtSearch.Clear();
            }
        }

        // opens up the DeleteWorkRequestForm
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // obtains the ID of the currently selected work request
            int selectedID = acquireSelectedID();

            if (selectedID != 0)
            {
                DeleteWorkRequestForm deleteWorkRequestForm = new DeleteWorkRequestForm(selectedID);
                deleteWorkRequestForm.ShowDialog();
                updateList();
                txtSearch.Clear();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkRequestForm_Load(object sender, EventArgs e)
        {
            updateList();
        }

        // method for reading the work request details from the database table and loading the information into the list
        private void updateList()
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectAllWorkRequests", myConn);

                myReader = myCommand.ExecuteReader();

                lstWorkRequests.Items.Clear();
                string heading = String.Format("{0, -12} {1, -55} {2, -15} {3, -15} {4, -10}", "Request ID", "Test Description", "Date Received", "Date Due", "Invoiced");
                lstWorkRequests.Items.Add(heading);
                lstWorkRequests.Items.Add("----------------------------------------------------------------------------------------------------------------------------");

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

                    // cleans up output
                    string invoiced = myReader.GetValue(6).ToString();
                    invoiced = (invoiced == "True" ? "Invoiced" : "Not Invoiced");

                    string nextEntry = String.Format("{0, -12} {1, -55} {2, -15} {3, -15} {4, -10}", myReader.GetValue(0).ToString(), myReader.GetValue(3).ToString(), dateReceived, dateDue, invoiced);
                    lstWorkRequests.Items.Add(nextEntry);
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method for reading work request details the that matches the search field from the database table and loading the information into the list
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSearchWorkRequest @Request_search_value", myConn);

                myCommand.Parameters.Add("@Request_search_value", SqlDbType.NVarChar, 30).Value = txtSearch.Text.Trim();

                myReader = myCommand.ExecuteReader();

                lstWorkRequests.Items.Clear();
                string heading = String.Format("{0, -12} {1, -55} {2, -15} {3, -15} {4, -10}", "Request ID", "Test Description", "Date Received", "Date Due", "Invoiced");
                lstWorkRequests.Items.Add(heading);
                lstWorkRequests.Items.Add("----------------------------------------------------------------------------------------------------------------------------");

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

                    // cleans up output
                    string invoiced = myReader.GetValue(6).ToString();
                    invoiced = (invoiced == "True" ? "Invoiced" : "Not Invoiced");

                    string nextEntry = String.Format("{0, -12} {1, -55} {2, -15} {3, -15} {4, -10}", myReader.GetValue(0).ToString(), myReader.GetValue(3).ToString(), dateReceived, dateDue, invoiced);
                    lstWorkRequests.Items.Add(nextEntry);
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method that obtains the ID of the currently selected work request and returns it
        private int acquireSelectedID()
        {
            int selectedID = 0;

            if (lstWorkRequests.SelectedIndex != -1)
            {
                String selectedItem = lstWorkRequests.SelectedItem.ToString();
                String[] splitValues = selectedItem.Split(' ');
                selectedID = int.Parse(splitValues[0]);
            }
            else
            {
                MessageBox.Show("Please select a work request from the list");
                return selectedID;
            }

            return selectedID;
        }

        // opens up the SelectTimePeriodForm
        private void btnWRPerTimePeriod_Click(object sender, EventArgs e)
        {
            SelectTimePeriodForm selectTimePeriodForm = new SelectTimePeriodForm();
            selectTimePeriodForm.ShowDialog();
            updateList();
            txtSearch.Clear();
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the existing work requests are displayed in the list.  To search for a specific work request, enter either the work request number" +
                         " into the search field." +
                         "\nTo add a new work request, click on the \"Add New Work Request\" button." +
                         "\nTo edit the details of an existing work request, select the work request from the list, and click on the \"Edit Work Request\" button." +
                         "\nTo delete an existing work request, select the work request from the list, and click on the \"Delete Work Request\" button." +
                         "\nOtherwise, to go back, click on the \"Back\" button", "Help");
        }
    }
}
