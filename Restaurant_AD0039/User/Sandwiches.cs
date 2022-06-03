using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Restaurant_AD0039
{
    public partial class frmSandwiches : Form
    {
        public frmSandwiches()
        {
            InitializeComponent();
            fill_ListBox();
        }


        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " + lbxSelection3.Text
               + "\n" + " Quantity: " + cmbxQuantity.Text);
        }

        private void btnClearSelection_Click_1(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection3.ClearSelected();
        }
        string DATA = "Provider = Microsoft.ACE.OLEDB.12.0; " +
            "Data Source = Database21.accdb";

        void fill_ListBox()
        {
            try
            {

                OleDbConnection con = new OleDbConnection(DATA);
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string selection = "Select Sandwiches from Sandwiches";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lbxSelection3.Items.Add(myReader["Sandwiches"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDSandwiches addsa = new ADDSandwiches();
            addsa.Dock = DockStyle.Fill;
            addsa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
