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
    public partial class InvoiceWorkRequestForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        public InvoiceWorkRequestForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            int selectedID = acquireSelectedID();

            if (selectedID != 0)
            {
                InvoiceConfirmationForm invoiceConfirmationForm = new InvoiceConfirmationForm(selectedID);
                invoiceConfirmationForm.ShowDialog();
                updateList();
                txtSearch.Clear();
            }

        }

        private void InvoiceWorkRequestForm_Load(object sender, EventArgs e)
        {
            updateList();
        }

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

                    if (myReader.GetValue(6).ToString() == "False")
                    {
                        lstWorkRequests.Items.Add(nextEntry);
                    }
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

                    if (myReader.GetValue(6).ToString() == "False")
                    {
                        lstWorkRequests.Items.Add(nextEntry);
                    }
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the work requests that have not yet been invoiced, are displayed in the list." +
                         "\nTo search for a specific work request, enter the work request number into the search field." +
                         "\nTo invoice a work request, select a work request from the list and click on the \"Invoice Selected Work Request\" button." +
                         "\nOtherwise, to go back, click on the \"Back\" button", "Help");
        }
    }
}
