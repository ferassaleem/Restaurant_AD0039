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
    public partial class frmrestaurant : Form
    {
        private List<User> UsersList = new List<User>();
        private List<Casheruser> CasheruserList = new List<Casheruser>();
        public frmrestaurant()
        {
            InitializeComponent();
            User user1 = new User("feras", "123");

            Casheruser user2 = new Casheruser("sameer", "1234");


            UsersList.Add(user1);
            CasheruserList.Add(user2);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            foreach (User user in UsersList)
            {
                if (username == user.UserName && password == user.Password)
                {
                    frmLogin frm = new frmLogin(txtUserName.Text);
                    frm.Show();
                    return;
                }
                
            }
            
            ////////////////////////////////////////
            string _cashname = txtUserName.Text;
            string _password = txtPassword.Text;
            foreach (Casheruser casheuser in CasheruserList)
            {
                if (_cashname == casheuser.CashName && _password == casheuser.Password)
                {
                    frmCaher frmc = new frmCaher(txtUserName.Text);
                    frmc.Show();
                    return;
                }
            }


        }
    }
}
