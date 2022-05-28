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
    public partial class frmDataBase : Form
    {

        string DATA = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = C:\\Users\\SCHOOL\\Desktop\\Database21.accdb";
        public frmDataBase()
        {
            InitializeComponent();
        }
        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection(DATA);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from courses", con);
            con.Open();
            adapter.Fill(dt);
            dgwcourses.DataSource = dt;
            con.Close();
            



        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            GetAllCourses();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection(DATA);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Courses values(@ID, @Name, @Age, @Phone, @Country, @Gender)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            cmd.Parameters.AddWithValue("@Phone", int.Parse(txtPhone.Text));
            cmd.Parameters.AddWithValue("@IdNumber", txtCountry.Text);
            cmd.Parameters.AddWithValue("@Gunder", gbxGender.Text );

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add is successfully");
            GetAllCourses();
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbxGender_Enter(object sender, EventArgs e)
        {
             if (rdbMale.Checked == true)
            {
                gbxGender.Text = rdbMale.Text;
            }
             else
            {
                gbxGender.Text = rdbFeMale.Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From Courses Where ID=@ID";
            OleDbConnection con = new OleDbConnection(DATA);

            OleDbCommand cmd = new OleDbCommand(delete, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete is successfully");
            GetAllCourses();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(DATA);
            con.Open();
            string update = "Update Courses " + " Set  Name=@Name, Age=@Age, Phone=@Phone, Country=@Country, Gender=@Gender" +" where ID=@ID ";
            OleDbCommand cmd = new OleDbCommand(update, con);

            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            cmd.Parameters.AddWithValue("@Phone", int.Parse(txtPhone.Text));
            cmd.Parameters.AddWithValue("@IdNumber", txtCountry.Text);
            cmd.Parameters.AddWithValue("@Gunder", gbxGender.Text);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update is successfully");
            GetAllCourses();
        }

        private void dgwcourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgwcourses.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgwcourses.CurrentRow.Cells[1].Value.ToString();
            txtAge.Text = dgwcourses.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgwcourses.CurrentRow.Cells[3].Value.ToString();
            txtCountry.Text = dgwcourses.CurrentRow.Cells[4].Value.ToString();
            gbxGender.Text = dgwcourses.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
