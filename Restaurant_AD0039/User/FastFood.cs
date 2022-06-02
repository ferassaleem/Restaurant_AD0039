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
    public partial class frmfastfood : Form
    {

        public frmfastfood()
        {
            InitializeComponent();
            fill_ListBox();
        }


        private void btnProcessOrder_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " + lbxSelection2.Text
                + "\n" + " Quantity: " + cmbxQuantity.Text);


        }

        private void btnClearSelection_Click_1(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection2.ClearSelected();
        }

        private void frmfastfood_Load(object sender, EventArgs e)
        {

        }
        string DATA = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = C:\\Users\\SCHOOL\\Desktop\\Database21.accdb";

        void fill_ListBox()
        {
            try
            {

                OleDbConnection con = new OleDbConnection(DATA);
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string selection = "Select fastfood from fastfood";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lbxSelection2.Items.Add(myReader["fastfood"].ToString());
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
            ADDfastfood addfa = new ADDfastfood();
            addfa.Show();
        }
        
    }
    
}
