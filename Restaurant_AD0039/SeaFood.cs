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
    
    public partial class frmSeaFood : Form
    {
        public frmSeaFood()
        {
            
            InitializeComponent();
            lbxSelection.Items.Add(new ListItem { Name = "tuna fish - $10", Value = 10 });
            lbxSelection.Items.Add(new ListItem { Name = "Fillet-fish - $13", Value = 13 });
            lbxSelection.Items.Add(new ListItem { Name = "Shrimp - $12", Value = 12 });
            lbxSelection.Items.Add(new ListItem { Name = "crab - $11", Value = 11 });
            lbxSelection.Items.Add(new ListItem { Name = "shell - $15", Value = 15 });
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            int x, y, d;

            x = Convert.ToInt32(((ListItem)lbxSelection.SelectedItem).Value);
            y = Convert.ToInt32(cmbxQuantity.SelectedItem);

            d = x * y;

            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " + lbxSelection.Text
                + "\n" + " Quantity: " + cmbxQuantity.Text  + "\n Total: " + d);
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection.ClearSelected();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
