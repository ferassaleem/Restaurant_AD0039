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
    public partial class frmAppetizers : Form
    {
        public frmAppetizers()
        {
            InitializeComponent();
            lbxSelection4.Items.Add(new ListItem { Name = "Potato - $2", Value = 2 });
            lbxSelection4.Items.Add(new ListItem { Name = "Vegetable salad - $2", Value = 2 });
            lbxSelection4.Items.Add(new ListItem { Name = "pickle - $1", Value = 1 });
            lbxSelection4.Items.Add(new ListItem { Name = "cheese - $1", Value = 1 });
            lbxSelection4.Items.Add(new ListItem { Name = "sizer salad - $5", Value = 5 });
        }


        private void btnProcessOrder_Click_1(object sender, EventArgs e)
        {
            int x4, y4, d4;

            x4 = Convert.ToInt32(((ListItem)lbxSelection4.SelectedItem).Value);
            y4 = Convert.ToInt32(cmbxQuantity.SelectedItem);

            d4 = x4 * y4;

            MessageBox.Show(" Items to Order \n ------------- \n Bag Type: " + lbxSelection4.Text
                + "\n" + " Quantity: " + cmbxQuantity.Text +
                 "\n Total: " + d4);
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            cmbxQuantity.SelectedIndex = 0;
            lbxSelection4.ClearSelected();
        }



    }
}
