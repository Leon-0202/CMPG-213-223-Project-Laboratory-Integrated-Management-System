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
    public partial class InvoicesPaymentsForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        public InvoicesPaymentsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            InvoiceWorkRequestForm invoiceWorkRequestForm = new InvoiceWorkRequestForm();
            invoiceWorkRequestForm.ShowDialog();
            updateList();
            txtSearch.Clear();
        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {
            int selectedID = acquireSelectedID();
            bool selectedIsPaid = acquireIsSelectedPaid(selectedID);

            if (selectedID != 0 && selectedIsPaid != true)
            {
                ReceivePaymentForm receivePaymentForm = new ReceivePaymentForm(selectedID);
                receivePaymentForm.ShowDialog();
                updateList();
                txtSearch.Clear();
            }
        }

        private void InvoicesPaymentsForm_Load(object sender, EventArgs e)
        {
            rdoAll.Checked = true;

            updateList();
        }

        private void updateList()
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectAllInvoices", myConn);

                myReader = myCommand.ExecuteReader();

                lstInvoices.Items.Clear();
                string heading = String.Format("{0, -12} {1, -12} {2, -23} {3, -23} {4, 20} {5, 20} {6, 20}", "Invoice ID", "Request ID", "Date Invoiced", "Date Payable", "Total Amount", "Amount Paid", "Amount Due");
                lstInvoices.Items.Add(heading);
                lstInvoices.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                while (myReader.Read())
                {
                    // cleans up output
                    string dateInvoiced = myReader.GetValue(2).ToString();
                    String[] DateInvoicedSplit = dateInvoiced.Split(' ');
                    dateInvoiced = DateInvoicedSplit[0];

                    // cleans up output
                    string datePayable = myReader.GetValue(3).ToString();
                    String[] DatePayableSplit = datePayable.Split(' ');
                    datePayable = DatePayableSplit[0];

                    // cleans up output
                    string paid = myReader.GetValue(7).ToString();
                    paid = (paid == "True" ? "Paid" : "Not paid");

                    double amountInvoiced = double.Parse(myReader.GetValue(4).ToString()) * 1.15;
                    double amountDue = double.Parse(myReader.GetValue(5).ToString());
                    double amountPaid = double.Parse(myReader.GetValue(6).ToString());

                    string nextEntry = String.Format("{0, -12} {1, -12} {2, -23} {3, -23} {4, 20} {5, 20} {6, 20}", myReader.GetValue(0), myReader.GetValue(1), dateInvoiced, datePayable, amountInvoiced.ToString("C2"), amountDue.ToString("C2"), amountPaid.ToString("C2"), paid);

                    if (rdoAll.Checked)
                    {
                        lstInvoices.Items.Add(nextEntry);
                    }
                    else if (rdoUnpaid.Checked && myReader.GetValue(7).ToString() == "False")
                    {
                        lstInvoices.Items.Add(nextEntry);
                    }
                    else if (rdoPaid.Checked && myReader.GetValue(7).ToString() == "True")
                    {
                        lstInvoices.Items.Add(nextEntry);
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
            searchInvoice();
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                updateList();
            }
            else
            {
                searchInvoice();
            }
        }

        private int acquireSelectedID()
        {
            int selectedID = 0;

            if (lstInvoices.SelectedIndex != -1)
            {
                String selectedItem = lstInvoices.SelectedItem.ToString();
                String[] splitValues = selectedItem.Split(' ');
                selectedID = int.Parse(splitValues[0]);
            }
            else
            {
                MessageBox.Show("Please select an invoice from the list");
                return selectedID;
            }

            return selectedID;
        }

        private bool acquireIsSelectedPaid(int selectedID)
        {
            bool selectedIsPaid = true;

            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSingleInvoice @Invoice_search_value", myConn);

                myCommand.Parameters.Add("@Invoice_search_value", SqlDbType.NVarChar, 30).Value = selectedID;

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.GetValue(7).ToString() == "False")
                    {
                        selectedIsPaid = false;
                    }
                    else if (myReader.GetValue(7).ToString() == "True")
                    {
                        MessageBox.Show("The selected invoice has already been paid, please select an unpaid invoice.");
                        return selectedIsPaid;
                    }
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return selectedIsPaid;
        }

        private void btnDisplayInvoice_Click(object sender, EventArgs e)
        {
            int selectedID = acquireSelectedID();

            if (selectedID != 0)
            {
                DisplayInvoice displayInvoiceForm = new DisplayInvoice(selectedID);
                displayInvoiceForm.ShowDialog();
                txtSearch.Clear();
            }
        }

        private void searchInvoice()
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSearchInvoice @Invoice_search_value", myConn);

                myCommand.Parameters.Add("@Invoice_search_value", SqlDbType.NVarChar, 30).Value = txtSearch.Text.Trim();

                myReader = myCommand.ExecuteReader();

                lstInvoices.Items.Clear();
                string heading = String.Format("{0, -12} {1, -12} {2, -23} {3, -23} {4, 20} {5, 20} {6, 20}", "Invoice ID", "Request ID", "Date Invoiced", "Date Payable", "Amount Invoiced", "Amount Paid", "Amount Due");
                lstInvoices.Items.Add(heading);
                lstInvoices.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                while (myReader.Read())
                {
                    // cleans up output
                    string dateInvoiced = myReader.GetValue(2).ToString();
                    String[] DateInvoicedSplit = dateInvoiced.Split(' ');
                    dateInvoiced = DateInvoicedSplit[0];

                    // cleans up output
                    string datePayable = myReader.GetValue(3).ToString();
                    String[] DatePayableSplit = datePayable.Split(' ');
                    datePayable = DatePayableSplit[0];

                    // cleans up output
                    string paid = myReader.GetValue(7).ToString();
                    paid = (paid == "True" ? "Paid" : "Not paid");

                    double amountInvoiced = double.Parse(myReader.GetValue(4).ToString()) * 1.15;
                    double amountDue = double.Parse(myReader.GetValue(5).ToString());
                    double amountPaid = double.Parse(myReader.GetValue(6).ToString());

                    string nextEntry = String.Format("{0, -12} {1, -12} {2, -23} {3, -23} {4, 20} {5, 20} {6, 20}", myReader.GetValue(0), myReader.GetValue(1), dateInvoiced, datePayable, amountInvoiced.ToString("C2"), amountDue.ToString("C2"), amountPaid.ToString("C2"), paid);

                    if (rdoAll.Checked)
                    {
                        lstInvoices.Items.Add(nextEntry);
                    }
                    else if (rdoUnpaid.Checked && myReader.GetValue(7).ToString() == "False")
                    {
                        lstInvoices.Items.Add(nextEntry);
                    }
                    else if (rdoPaid.Checked && myReader.GetValue(7).ToString() == "True")
                    {
                        lstInvoices.Items.Add(nextEntry);
                    }
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the existing invoices are displayed in the list.  You can also select to view all the paid, or all the unpaid invoices.  " +
                         "\nTo search for a specific invoice, enter the invoice number into the search field." +
                         "\nTo show a detailed report of an invoice, select an invoice from the list and click on the \"Display Selected Invoice\" button." +
                         "\nTo invoice a work request that has not yes been invoiced, click on the \"Invoice a Work Request\" button." +
                         "\nTo receive a payment for an invoice, select the invoice from the list, and click on the \"Receive Payment\" button." +
                         "\nOtherwise, to go back, click on the \"Back\" button", "Help");
        }
    }
}
