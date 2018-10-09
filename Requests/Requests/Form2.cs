using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requests
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'items.ABRs' table. You can move, or remove it, as needed.
            this.aBRsTableAdapter.Fill(this.items.ABRs);
            // TODO: This line of code loads data into the 'fM_OPERATIONSDataSet.Requests' table. You can move, or remove it, as needed.
            this.requestsTableAdapter.Fill(this.fM_OPERATIONSDataSet.Requests);

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 a = new Form1();
            Hide();
            a.Show();
        }
    }
}
