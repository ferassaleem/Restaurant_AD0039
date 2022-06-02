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
    
    public partial class frmSeaFood : Form
    {
        public frmSeaFood()
        {

            InitializeComponent();
            fill_ListBox();
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {


            

            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " + lbxSelection.Text
                + "\n" + " Quantity: " + cmbxQuantity.Text  );
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection.ClearSelected();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        string DATA = "Provider = Microsoft.ACE.OLEDB.12.0; " +
            "Data Source = C:\\Users\\SCHOOL\\Desktop\\feras saleem\\Restaurant_AD0039\\Restaurant_AD0039\\DataBase\\Database21.accdb";

        void fill_ListBox()
        {
            try
            {

                OleDbConnection con = new OleDbConnection(DATA);
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string selection = "Select SeaFood from SeaFood";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    lbxSelection.Items.Add(myReader["SeaFood"].ToString());
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
            ADDSeaFood addse = new ADDSeaFood();
            addse.Show();
        }
    }
}
