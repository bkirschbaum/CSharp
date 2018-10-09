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
using System.Configuration;
namespace Requests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestConnection_Click(object sender, EventArgs e)
        {
            ValidConnection.Text = ValidConnection1();
        }


        private void UploadButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = @"INSERT INTO Requests ([First Name],[Last Name],
            [Request]) VALUES ('" + FNameBox.Text +"','" + LNameBox.Text +"','" + RequestBox.Text +"')";
            cmd.Connection = sqlConnection2;
            sqlConnection2.Open();

            reader = cmd.ExecuteReader();
            sqlConnection2.Close();


        }



        public static string ValidConnection1()
        {
            try
            {
                SqlConnection sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
                SqlCommand cmd = new SqlCommand();
                sqlConnection1.Open();
                sqlConnection1.Close();
                return "Success";
            }
            catch (Exception ex)
            {

                return "Failed";
            }

        }


        private void Hide_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            Hide();
            f.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fM_OPERATIONSDataSet.Requests' table. You can move, or remove it, as needed.
            this.requestsTableAdapter.Fill(this.fM_OPERATIONSDataSet.Requests);

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.BackColor = Color.Red;
            ListBox newBox = new ListBox();
            newBox.Location = new System.Drawing.Point(10, 10);
        }
    }


}
