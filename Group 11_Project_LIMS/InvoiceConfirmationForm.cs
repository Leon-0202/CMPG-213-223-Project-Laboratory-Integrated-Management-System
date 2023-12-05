using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_11_Project_LIMS
{
    public partial class InvoiceConfirmationForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        int selectedID;

        public InvoiceConfirmationForm()
        {
            InitializeComponent();
        }

        public InvoiceConfirmationForm(int selectedID)
        {
            InitializeComponent();

            this.selectedID = selectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (inputIsValid())
            {
                try
                {
                    myConn.Open();

                    myCommand = new SqlCommand("EXECUTE InvoiceWorkRequest @Work_request_ID, @Date_invoiced, @Date_payable, @Amount_invoiced, @Amount_paid, @Amount_due, @Paid_YN", myConn);

                    myCommand.Parameters.Add("@Work_request_ID", SqlDbType.Int).Value = selectedID;
                    myCommand.Parameters.Add("@Date_invoiced", SqlDbType.Date).Value = DateTime.Today.Date;
                    myCommand.Parameters.Add("@Date_payable", SqlDbType.Date).Value = DateTime.Today.Date.AddDays(14);
                    myCommand.Parameters.Add("@Amount_invoiced", SqlDbType.SmallMoney).Value = Math.Round(Decimal.Parse(txtAmount.Text), 2);
                    myCommand.Parameters.Add("@Amount_paid", SqlDbType.SmallMoney).Value = 0.0;
                    myCommand.Parameters.Add("@Amount_due", SqlDbType.SmallMoney).Value = Math.Round(Decimal.Parse(txtAmount.Text) * (Decimal)1.15, 2);
                    myCommand.Parameters.Add("Paid_YN", SqlDbType.Bit).Value = false;

                    myCommand.ExecuteNonQuery();

                    myConn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Work Request successfully invoiced", "Task Successful");
                this.Close();
            }
        }

        private void InvoiceConfirmationForm_Load(object sender, EventArgs e)
        {
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

                    lblWRNoDisplay.Text = myReader.GetValue(0).ToString();
                    lblClientDisplay.Text = myReader.GetValue(1).ToString();
                    lblEmployeeDisplay.Text = myReader.GetValue(2).ToString();
                    lblTestDescriptionDisplay.Text = myReader.GetValue(3).ToString();
                    lblDateReceivedDisplay.Text = dateReceived;
                    lblDateDueDisplay.Text = dateDue;
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

            if (string.IsNullOrEmpty(txtAmount.Text) == false)
            {
                if (Double.TryParse(txtAmount.Text, out double test))
                {
                    if (test >= 0)
                    {
                        inputValid = true;
                    }
                    else MessageBox.Show("The amount cannot be less than zero");
                }
                else MessageBox.Show("The amount should contain only digits");
            }
            else MessageBox.Show("Please enter an amount");

            return inputValid;
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To complete the invoicing process, enter the before tax-value of the work done into the space provided and click on the \"Invoice\" button." +
                          "\nThe tax amount will automatically be added to this amount." +
                          "\nOtherwise, to go back without making any changes, click on the \"Cancel\" button", "Help");
        }
    }
}
