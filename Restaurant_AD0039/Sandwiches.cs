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
    public partial class frmSandwiches : Form
    {
        public frmSandwiches()
        {
            InitializeComponent();
            lbxSelection3.Items.Add(new ListItem { Name = "Fahita - $4", Value = 4 });
            lbxSelection3.Items.Add(new ListItem { Name = "burger - $5", Value = 5 });
            lbxSelection3.Items.Add(new ListItem { Name = "Shawerma - $2", Value = 2 });
            lbxSelection3.Items.Add(new ListItem { Name = "Stick - $6", Value = 6 });
            lbxSelection3.Items.Add(new ListItem { Name = "Zinger - $3", Value = 3 });
        }


        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            int x3, y3, d3;

            x3 = Convert.ToInt32(((ListItem)lbxSelection3.SelectedItem).Value);
            y3 = Convert.ToInt32(cmbxQuantity.SelectedItem);

            d3 = x3 * y3;

            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " + lbxSelection3.Text
                + "\n" + " Quantity: " + cmbxQuantity.Text +
                 "\n Total: " + d3);
        }

        private void btnClearSelection_Click_1(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection3.ClearSelected();
        }
    }
}
