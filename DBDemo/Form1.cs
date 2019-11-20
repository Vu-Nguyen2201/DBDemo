using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace DBDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data Source=DESKTOP-MHABU3S;Initial Catalog=DBDemo;Integrated Security=True
            
            //SqlConnection conn = DBUtils.GetDBConnection();

            //try
            //{
                
            //    MessageBox.Show("Connection successful!");
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);
            //}

            //Console.Read();
        }

        private void btnGoi_Click(object sender, EventArgs e)
        {
            //"SELECT * FROM user WHERE username LIKE '".$user."' AND password LIKE '".$pass."'";
            string Name = "Vu";
            string MSSV = "18133064";
            string sql = "SELECT * FROM SinhVien WHERE Name = 'Vu' AND MSSV = '18133064'";
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

         
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    lblName.Text = Convert.ToString(reader.GetOrdinal("Name"));
                    lblMSSV.Text = Convert.ToString(reader.GetOrdinal("MSSV"));
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string Name = "Nguyen";
            string MSSV = "18133046";
            string UserName = "l";
            string Password = "1234";
            string sql = "SELECT * FROM SinhVien WHERE Name = '" + Name + "' AND MSSV = '" + MSSV +"'";
            sql = "INSERT INTO SinhVien (Name, MSSV, UserName, PassWord) VALUES ('Nguyen','18133046','l','1234')";
            SqlConnection conn = DBUtils.GetDBConnection();
            
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "INSERT INTO SinhVien (Name, MSSV, UserName, PassWord) VALUES (@Name,@MSSV,@UserName,@PassWord)";

            //cmd.Connection = conn;
            
            //conn.Open();
        }
    }
}
