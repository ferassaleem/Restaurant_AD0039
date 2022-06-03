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
    public partial class frmJuices : Form
    {
        public frmJuices()
        {
            InitializeComponent();
            fill_ListBox();
        }

        private void frmJuices_Load(object sender, EventArgs e)
        {

        }

        private void btnProcessOrder_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " + lbxSelection5.Text
                + "\n" + " Quantity: " + cmbxQuantity.Text);
        }

        private void btnClearSelection_Click_1(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection5.ClearSelected();
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
                string selection = "Select Juices from Juices";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lbxSelection5.Items.Add(myReader["Juices"].ToString());
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
            ADDJuices addju = new ADDJuices();
            addju.Dock = DockStyle.Fill;
            addju.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
