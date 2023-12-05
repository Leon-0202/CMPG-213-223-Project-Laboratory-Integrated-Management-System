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
    public partial class ReceivePaymentForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        int selectedID;

        public ReceivePaymentForm()
        {
            InitializeComponent();
        }

        public ReceivePaymentForm(int selectedID)
        {
            InitializeComponent();

            this.selectedID = selectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {
            if (inputIsValid())
            {
                try
                {
                    myConn = new SqlConnection(connString);

                    myConn.Open();

                    myCommand = new SqlCommand("EXECUTE SelectSingleInvoice @Invoice_ID", myConn);

                    myCommand.Parameters.Add("@Invoice_ID", SqlDbType.Int).Value = selectedID;

                    myReader = myCommand.ExecuteReader();

                    decimal invoicedAmount = 0.0m;
                    decimal paidAmount = 0.0m;
                    decimal dueAmount = 0.0m;
                    decimal paymentAmount = Decimal.Parse(txtAmount.Text);

                    while (myReader.Read())
                    {
                        invoicedAmount = Decimal.Parse(myReader.GetValue(4).ToString());
                        paidAmount = Decimal.Parse(myReader.GetValue(5).ToString());
                        dueAmount = Decimal.Parse(myReader.GetValue(6).ToString());
                    }

                    if (paymentAmount <= dueAmount)
                    {
                        receivePayment(invoicedAmount, paidAmount, dueAmount, paymentAmount);

                        myConn.Close();

                        MessageBox.Show("Payment successfully made", "Task Successful");
                        this.Close();
                    }
                    else if (paymentAmount > dueAmount)
                    {
                        MessageBox.Show("The payment amount cannot be larger than the amount due.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ReceivePaymentForm_Load(object sender, EventArgs e)
        {
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

                    double amountInvoiced = double.Parse(myReader.GetValue(4).ToString()) * 1.15;
                    double amountPaid = double.Parse(myReader.GetValue(5).ToString());
                    double amountDue = double.Parse(myReader.GetValue(6).ToString());

                    lblInvoiceNoDisplay.Text = myReader.GetValue(0).ToString();
                    lblWRNoDisplay.Text = myReader.GetValue(1).ToString();
                    lblDateInvoicedDisplay.Text = dateInvoiced;
                    lblDatePayableDisplay.Text = datePayable;
                    lblAmountDisplay.Text = amountInvoiced.ToString("C2");
                    lblAmountPaidDisplay.Text = amountPaid.ToString("C2");
                    lblAmountDueDisplay.Text = amountDue.ToString("C2");
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void receivePayment(decimal invoicedAmount, decimal paidAmount, decimal dueAmount, decimal paymentAmount)
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE UpdateInvoice @Invoice_ID, @Amount_invoiced, @Amount_paid, @Amount_due, @Paid_YN", myConn);

                myCommand.Parameters.Add("@Invoice_ID", SqlDbType.Int).Value = selectedID;
                myCommand.Parameters.Add("@Amount_invoiced", SqlDbType.Decimal).Value = invoicedAmount;
                myCommand.Parameters.Add("@Amount_paid", SqlDbType.Decimal).Value = paidAmount + paymentAmount;
                myCommand.Parameters.Add("@Amount_due", SqlDbType.Decimal).Value = dueAmount - paymentAmount;
                myCommand.Parameters.Add("@Paid_YN", SqlDbType.Bit).Value = (paymentAmount == dueAmount ? 1 : 0);

                myCommand.ExecuteNonQuery();

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
                    if (test > 0)
                    {
                        inputValid = true;
                    }
                    else MessageBox.Show("The amount must be larger than zero");
                }
                else MessageBox.Show("The amount should contain only digits");
            }
            else MessageBox.Show("Please enter an amount");

            return inputValid;
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To complete the payment process, enter the payment into the space provided  and click on the \"Receive Payment\" button." +
                          "\nOtherwise, to go back without making any changes, click on the \"Cancel\" button", "Help");
        }
    }
}
