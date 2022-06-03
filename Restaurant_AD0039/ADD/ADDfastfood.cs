﻿using System;
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
    public partial class ADDfastfood : Form
    {
        string DATA = "Provider = Microsoft.ACE.OLEDB.12.0; " +
            "Data Source = Database21.accdb";

        public ADDfastfood()
        {
            InitializeComponent();
        }
        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection(DATA);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from fastfood", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(DATA);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into fastfood values(@ID, @fastfood, @fastfoodPrice)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@fastfood", txtName.Text);
            cmd.Parameters.AddWithValue("@fastfoodPrice", int.Parse(txtAge.Text));


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add is successfully");
            GetAllCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From fastfood Where ID=@ID";
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
            string update = "Update fastfood " + " Set  fastfood=@fastfood, fastfoodPrice=@fastfoodPrice" + " where ID=@ID ";
            OleDbCommand cmd = new OleDbCommand(update, con);

            cmd.Parameters.AddWithValue("@fastfood", txtName.Text);
            cmd.Parameters.AddWithValue("@fastfoodPrice", int.Parse(txtAge.Text));
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update is successfully");
            GetAllCourses();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
