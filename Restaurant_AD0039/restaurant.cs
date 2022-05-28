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
        public frmrestaurant()
        {
            InitializeComponent();
            User user1 = new User("feras", "123");
            User user2 = new User("sameer", "1234");
            User user3 = new User("ramadan", "12345");
            User user4 = new User("saleem", "123456");
            UsersList.Add(user1);
            UsersList.Add(user2);
            UsersList.Add(user3);
            UsersList.Add(user4);
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
            MessageBox.Show("Worng UserName or Password");


        }
    }
}
