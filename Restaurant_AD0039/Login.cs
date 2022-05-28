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
    public partial class frmLogin : Form
    {
        private string _username;
        public frmLogin(string username)
        {
            _username = username;
            InitializeComponent();
        }

        private void btnSeafood_Click(object sender, EventArgs e)
        {
            frmSeaFood SeaFood = new frmSeaFood();
            SeaFood.TopLevel = false;
            this.panel3.Controls.Add(SeaFood);
            SeaFood.Show();
        }

        private void btnFastfood_Click(object sender, EventArgs e)
        {
            frmfastfood fastfood = new frmfastfood();
            fastfood.TopLevel = false;
            this.panel3.Controls.Add(fastfood);
            fastfood.Show();
        }

        private void btnSandwiches_Click(object sender, EventArgs e)
        {
            frmSandwiches Sandwiches = new frmSandwiches();
            Sandwiches.TopLevel = false;
            this.panel3.Controls.Add(Sandwiches);
            Sandwiches.Show();
        }

        private void btnAppetizers_Click(object sender, EventArgs e)
        {
            frmAppetizers Appetizers = new frmAppetizers();
            Appetizers.TopLevel = false;
            this.panel3.Controls.Add(Appetizers);
            Appetizers.Show();
        }

        private void btnJuices_Click(object sender, EventArgs e)
        {
            frmJuices Juices = new frmJuices();
            Juices.TopLevel = false;
            this.panel3.Controls.Add(Juices);
            Juices.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + _username;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            frmDataBase Data = new frmDataBase();
            Data.TopLevel = false;
            this.panel3.Controls.Add(Data);
            Data.Show();
        }
    }
}
