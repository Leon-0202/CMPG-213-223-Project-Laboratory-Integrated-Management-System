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
using System.Windows.Forms.VisualStyles;

namespace Group_11_Project_LIMS
{
    public partial class DisplayInvoice : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        int selectedID;

        public DisplayInvoice()
        {
            InitializeComponent();
        }

        public DisplayInvoice(int selectedID)
        {
            InitializeComponent();

            this.selectedID = selectedID;
        }

        private void DisplayInvoice_Load(object sender, EventArgs e)
        {
            lblDateTimeIssued.Text = DateTime.Now.ToString();

            int selectedWorkRequestID = loadInvoice();
            int selectedClientID = loadWorkRequest(selectedWorkRequestID);
            loadClient(selectedClientID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int loadInvoice()
        {
            int selectedWorkRequestID = -1;

            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSingleInvoice @Invoice_ID", myConn);

                myCommand.Parameters.Add("@Invoice_ID", SqlDbType.Int).Value = selectedID;

                myReader = myCommand.ExecuteReader();

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

                    lblInvoiceNoDisplay.Text = myReader.GetValue(0).ToString();
                    lblWorkRequestNoDisplay.Text = myReader.GetValue(1).ToString();
                    lblDateInvoicedDisplay.Text = dateInvoiced;
                    lblDatePayableDisplay.Text = datePayable;

                    decimal amountInvoiced = decimal.Parse(myReader.GetValue(4).ToString());
                    decimal totalTax = Math.Round(decimal.Parse(myReader.GetValue(4).ToString()) * (decimal)0.15, 2);
                    decimal amountDue = Math.Round(decimal.Parse(myReader.GetValue(4).ToString()) * (decimal)1.15, 2);

                    lblAmountInvoicedDisplay.Text = amountInvoiced.ToString("C2");
                    lblTotalTaxDisplay.Text = totalTax.ToString("C2");
                    lblAmountDueDisplay.Text = amountDue.ToString("C2");

                    selectedWorkRequestID = int.Parse(myReader.GetValue(1).ToString());
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return selectedWorkRequestID;
        }

        private int loadWorkRequest(int selectedWorkRequestID)
        {
            int selectedClientID = -1;

            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSingleWorkRequest @Work_request_ID", myConn);

                myCommand.Parameters.Add("@Work_request_ID", SqlDbType.Int).Value = selectedWorkRequestID;

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    selectedClientID = int.Parse(myReader.GetValue(1).ToString());

                    lblTestDescription.Text = myReader.GetValue(3).ToString();
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return selectedClientID;
        }

        private void loadClient(int selectedClientID)
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSingleClient @Client_ID", myConn);

                myCommand.Parameters.Add("@Client_ID", SqlDbType.Int).Value = selectedClientID;

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    lblClientNameDisplay.Text = myReader.GetValue(1) + " " + myReader.GetValue(2);
                    lblContactNoDisplay.Text = myReader.GetValue(3).ToString();
                    lblEmailDisplay.Text = myReader.GetValue(4).ToString();
                    lblAddressNoDisplay.Text = myReader.GetValue(5).ToString();
                    lblAddressStreetDisplay.Text = myReader.GetValue(6).ToString();
                    lblAddressCityDisplay.Text = myReader.GetValue(7).ToString();
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
