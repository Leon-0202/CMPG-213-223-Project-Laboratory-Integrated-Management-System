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
    public partial class DeleteWorkRequestForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        int selectedID;

        public DeleteWorkRequestForm()
        {
            InitializeComponent();
        }

        public DeleteWorkRequestForm(int selectedID)
        {
            InitializeComponent();

            this.selectedID = selectedID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                myCommand = new SqlCommand("EXECUTE DeleteWorkRequest @Work_request_ID", myConn);

                myCommand.Parameters.Add("@Work_request_ID", SqlDbType.Int).Value = selectedID;

                myCommand.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Work Request successfully deleted", "Task Successful");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteWorkRequestForm_Load(object sender, EventArgs e)
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
                    lblTestDisplay.Text = myReader.GetValue(3).ToString();
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
    }
}
