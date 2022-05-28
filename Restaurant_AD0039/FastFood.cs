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
    public partial class frmfastfood : Form
    {

        public frmfastfood()
        {
            InitializeComponent();
            lbxSelection2.Items.Add(new ListItem { Name = "Fahita - $8", Value = 8 });
            lbxSelection2.Items.Add(new ListItem { Name = "burger - $9", Value = 9 });
            lbxSelection2.Items.Add(new ListItem { Name = "Shawerma - $5", Value = 5 });
            lbxSelection2.Items.Add(new ListItem { Name = "Stick - $11", Value = 11 });
            lbxSelection2.Items.Add(new ListItem { Name = "Zinger - $6", Value = 6 });
        }


        private void btnProcessOrder_Click_1(object sender, EventArgs e)
        {
            int x2, y2, d2;

            x2 = Convert.ToInt32(((ListItem)lbxSelection2.SelectedItem).Value);
            y2 = Convert.ToInt32(cmbxQuantity.SelectedItem);

            d2 = x2 * y2;

            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " + lbxSelection2.Text
                + "\n" + " Quantity: " + cmbxQuantity.Text +
                "\n Total: " + d2);
        }

        private void btnClearSelection_Click_1(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection2.ClearSelected();
        }

        private void frmfastfood_Load(object sender, EventArgs e)
        {

        }
    }
    
}
