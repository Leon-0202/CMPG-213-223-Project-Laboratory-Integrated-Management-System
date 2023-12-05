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
    public partial class WorkRequestsPerTime : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        DateTime startDate;
        DateTime endDate;

        public WorkRequestsPerTime()
        {
            InitializeComponent();
        }

        public WorkRequestsPerTime(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            this.startDate = startDate;
            this.endDate = endDate;
        }

        private void WorkRequestsPerTime_Load(object sender, EventArgs e)
        {
            // cleans up to output
            string dateStart = startDate.ToString();
            String[] dateStartSplit = dateStart.Split(' ');
            dateStart = dateStartSplit[0];

            // cleans up to output
            string dateEnd = endDate.ToString();
            String[] dateEndSplit = dateEnd.Split(' ');
            dateEnd = dateEndSplit[0];

            lblPeriod.Text = "From " + dateStart + " to " + dateEnd;
            lblDateTimeIssued.Text = DateTime.Now.ToString();

            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE WorkRequestsPerTimePeriod @Start_date, @End_date", myConn);

                myCommand.Parameters.Add("@Start_date", SqlDbType.Date).Value = startDate;
                myCommand.Parameters.Add("@End_date", SqlDbType.Date).Value = endDate;

                myReader = myCommand.ExecuteReader();

                lstDisplay.Items.Clear();
                string heading = String.Format("{0,-10} {1,-10} {2, 10}", "Year", "Month", "Count");
                lstDisplay.Items.Add(heading);
                lstDisplay.Items.Add("-------------------------------------------");

                while (myReader.Read())
                {
                    string nextEntry = String.Format("{0,-10} {1,-10} {2, 10}", myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2));
                    lstDisplay.Items.Add(nextEntry);
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
