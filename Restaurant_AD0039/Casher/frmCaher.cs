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
    public partial class frmCaher : Form
    {
        private string _cashname;
        public frmCaher(string cashname)
        {
            _cashname = cashname;
            InitializeComponent();
        }
        
        private void LoadData()
        {
            
            for (int i = 0; i < dtGroups.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Click += new EventHandler(btnGroup_Click); 
                btn.Text = dtGroups.Rows[i]["Name"].ToString();
                btn.Tag = dtGroups.Rows[i]["ID"].ToString();
                btn.Height = 55;
                btn.BackColor = Color.LightBlue;
                btn.ForeColor = Color.Black;
                panel1.Controls.Add(btn);
                btn.Dock = DockStyle.Top;
            }
 
        }
        DataTable dtGroups = new DataTable();
        DataTable dtItem = new DataTable();

        private void frmCaher_Load(object sender, EventArgs e)
        {
            
            dtGroups.Columns.Add("ID");
            dtGroups.Columns.Add("Name");

            dtItem.Columns.Add("ID");
            dtItem.Columns.Add("Name");
            dtItem.Columns.Add("Group_ID");

            dtGroups.Rows.Add("1", "SeaFood");
            dtGroups.Rows.Add("2", "Fastfood");
            dtGroups.Rows.Add("3", "Sandwiches");
            dtGroups.Rows.Add("4", "Appetizers");
            dtGroups.Rows.Add("5", "Juices");
            //SeaFood
            dtItem.Rows.Add("1", "tuna fish - $10", "1");
            dtItem.Rows.Add("2", "Fillet-fish - $13", "1");
            dtItem.Rows.Add("3", "Shrimp - $12", "1");
            dtItem.Rows.Add("4", "crab - $11", "1");
            dtItem.Rows.Add("5", "shell - $15", "1");
            //Fast Food
            dtItem.Rows.Add("6", "Fahita - $8", "2");
            dtItem.Rows.Add("7", "burger - $9", "2");
            dtItem.Rows.Add("8", "Shawerma - $5", "2");
            dtItem.Rows.Add("9", "Stick - $11", "2");
            dtItem.Rows.Add("10", "Zinger - $6", "2");
            //Sandwiches
            dtItem.Rows.Add("11", "Fahita - $4", "3");
            dtItem.Rows.Add("12", "burger - $5", "3");
            dtItem.Rows.Add("13", "Shawerma - $2", "3");
            dtItem.Rows.Add("14", "Stick - $6", "3");
            dtItem.Rows.Add("15", "Zinger - $3", "3");
            //Appetizers
            dtItem.Rows.Add("16", "Potato - $2", "4");
            dtItem.Rows.Add("17", "Vegetable salad - $2", "4");
            dtItem.Rows.Add("18", "pickle - $1", "4");
            dtItem.Rows.Add("19", "cheese - $1", "4");
            dtItem.Rows.Add("20", "sizer salad - $5", "4");
            //Juices
            dtItem.Rows.Add("21", "Orange - $2", "5");
            dtItem.Rows.Add("22", "Limon - $1", "5");
            dtItem.Rows.Add("23", "Strawberry - $3", "5");
            dtItem.Rows.Add("24", "Grape - $2", "5");
            dtItem.Rows.Add("25", "Fruit - $4", "5");

            LoadData();

        }
        private void btnGroup_Click(object sender, EventArgs e)
        {

            Button _btn = (Button)sender;
            string _ID = _btn.Tag.ToString();
            DataRow[] dt_Item = dtItem.Select("Group_ID=" + _ID);
            int x = 10;
            int y = 10;
            int counter = 0;
            for (int i = 0; i < dt_Item.Length; i++)
            {

                Button btn = new Button();
                btn.Width = 150;
                btn.Height = 70;
                btn.Text = dt_Item[i]["Name"].ToString();
                btn.Tag = dt_Item[i]["ID"].ToString();
                btn.BackColor = Color.LightBlue;
                btn.ForeColor = Color.Black;
                panel2.Controls.Add(btn);
                counter++;
                btn.Location = new Point(x, y);
                x += btn.Width + 5;
                if (counter == 5)
                {
                    y += btn.Height + 5;
                    x = 10;
                    counter = 0;
                }


            }

        }

    }
}
