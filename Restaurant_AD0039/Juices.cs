using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_AD0039
{
    public partial class frmJuices : Form
    {
        public frmJuices()
        {
            InitializeComponent();
            lbxSelection5.Items.Add(new ListItem { Name = "Orange - $2", Value = 2 });
            lbxSelection5.Items.Add(new ListItem { Name = "Limon - $1", Value = 1 });
            lbxSelection5.Items.Add(new ListItem { Name = "Strawberry - $3", Value = 3 });
            lbxSelection5.Items.Add(new ListItem { Name = "Grape - $2", Value = 2 });
            lbxSelection5.Items.Add(new ListItem { Name = "Fruit - $4", Value = 4 });
        }





        private void frmJuices_Load(object sender, EventArgs e)
        {

        }

        private void btnProcessOrder_Click_1(object sender, EventArgs e)
        {
            int x5, y5, d5;

            x5 = Convert.ToInt32(((ListItem)lbxSelection5.SelectedItem).Value);
            y5 = Convert.ToInt32(cmbxQuantity.SelectedItem);

            d5 = x5 * y5;

            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " +
                lbxSelection5.Text+ "\n" + " Quantity: " +
                cmbxQuantity.Text +
                "\n Total: " + d5);
        }

        private void btnClearSelection_Click_1(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection5.ClearSelected();
        }
    }
}
