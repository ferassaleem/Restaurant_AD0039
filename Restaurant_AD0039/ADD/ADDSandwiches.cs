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
    public partial class ADDSandwiches : Form
    {
        string DATA = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = C:\\Users\\SCHOOL\\Desktop\\Database21.accdb";

        public ADDSandwiches()
        {
            InitializeComponent();
        }
        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection(DATA);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Sandwiches", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();




        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(DATA);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Sandwiches values(@ID, @Sandwiches, @SandwichesPrice)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Sandwiches", txtName.Text);
            cmd.Parameters.AddWithValue("@SandwichesPrice", int.Parse(txtAge.Text));


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add is successfully");
            GetAllCourses();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(DATA);
            con.Open();
            string update = "Update Sandwiches " + " Set  Sandwiches=@Sandwiches, SandwichesPrice=@SandwichesPrice" + " where ID=@ID ";
            OleDbCommand cmd = new OleDbCommand(update, con);

            cmd.Parameters.AddWithValue("@Sandwiches", txtName.Text);
            cmd.Parameters.AddWithValue("@SandwichesPrice", int.Parse(txtAge.Text));
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update is successfully");
            GetAllCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From Sandwiches Where ID=@ID";
            OleDbConnection con = new OleDbConnection(DATA);

            OleDbCommand cmd = new OleDbCommand(delete, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete is successfully");
            GetAllCourses();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSandwiches frmsa = new frmSandwiches();
            frmsa.Show();
            ADDSandwiches addsa = new ADDSandwiches();
            addsa.Close();
        }
    }
}
