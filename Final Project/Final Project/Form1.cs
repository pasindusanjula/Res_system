using Final_Project.Common;
using Final_Project.DB;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(DBCommon.ConString);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text.Trim() == "" || textPassword.Text.Trim() == "")
            {
                MessageBox.Show("Enter username & password ");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = string.Format(@"SELECT * FROM  UserInfo WHERE  Username ='{0}' AND UserPassword ='{1}'", textUsername.Text.Trim(), textPassword.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    UserOrderForm userOrderForm = new UserOrderForm();
                    userOrderForm.Show();
                    this.Hide();

                    CmnMethods.GetUserInfo(dataTable);


                }
                else
                {
                    MessageBox.Show("Invalid Username & password ");
                }


            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (textUsername.Text.Trim() == "" || textPassword.Text.Trim() == "")
            {
                MessageBox.Show("Fill username and password ");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = @"INSERT INTO UserInfo (Username,UserPassword,Contact,AddedDate,AddedBy) VALUES (@Username,@UserPassword,@Contact,@AddedDate,@AddedBy)";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@Username", textUsername.Text.Trim());
                command.Parameters.AddWithValue("@UserPassword", textPassword.Text.Trim());
                command.Parameters.AddWithValue("@Contact", "");
                command.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                command.Parameters.AddWithValue("@AddedBy", Global.UserInfo.UsertId);//Login user ID
                command.ExecuteNonQuery();
                MessageBox.Show("Signup successfully. Now Login !");
                sqlCon.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Global.UserInfo = new UserInfo();
            Global.UserInfo.Username = "Guest";

            UserOrderForm userOrderForm = new UserOrderForm();
            userOrderForm.Show();
            this.Hide();
        }
    }
}
