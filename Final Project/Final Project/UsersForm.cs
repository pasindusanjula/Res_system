﻿using Final_Project.Common;
using Final_Project.DB;
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
    public partial class UsersForm : Form
    {
        SqlConnection sqlCon = new SqlConnection(DBCommon.ConString);
        public UsersForm()
        {
            InitializeComponent();
            usernameLabel.Text = Global.UserInfo.Username;
            LoadUsers();
        }
        private void LoadUsers()
        {
            sqlCon = CmnMethods.OpenConnectionString(sqlCon);
            string query = "SELECT * FROM UserInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            userGridView.DataSource = dataSet.Tables[0];
            sqlCon.Close();

            //hide common columns like addeddate, addedBy,updatedate,updatedby
            userGridView.Columns[0].Visible = false;
            userGridView.Columns[4].Visible = false;
            userGridView.Columns[5].Visible = false;
            userGridView.Columns[6].Visible = false;
            userGridView.Columns[7].Visible = false;
        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderForm userOrder = new UserOrderForm();
            userOrder.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Trim() == "" || contactTextBox.Text.Trim() == "" || passwordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Fill all fields ");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = @"INSERT INTO UserInfo (Username,Contact,UserPassword,AddedDate,AddedBy) VALUES (@Username,@Contact,@UserPassword,@AddedDate,@AddedBy)";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@Username", usernameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Contact", contactTextBox.Text.Trim());
                command.Parameters.AddWithValue("@UserPassword", passwordTextBox.Text.Trim());
                command.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                command.Parameters.AddWithValue("@AddedBy", 1);//Login user ID
                command.ExecuteNonQuery();
                MessageBox.Show("User Created Successfully ");
                sqlCon.Close();
                LoadUsers();
                Reset();
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text.Trim() == "" || Convert.ToInt32(userIdTextBox.Text) == 0)
            {
                MessageBox.Show("Select An User ");
            }
            else if (usernameTextBox.Text.Trim() == "" || contactTextBox.Text.Trim() == "" || passwordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Fill All Fields");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = @"UPDATE UserInfo SET Username = @Username,Contact = @Contact ,UserPassword = @UserPassword  WHERE UserId = @UserId ";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@UserId", userIdTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Username", usernameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Contact", contactTextBox.Text.Trim());
                command.Parameters.AddWithValue("@UserPassword", passwordTextBox.Text.Trim());
                command.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                command.Parameters.AddWithValue("@UpdatedBy", 1);//Login user ID
                command.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully ");
                sqlCon.Close();
                LoadUsers();
                Reset();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text.Trim() == "" || Convert.ToInt32(userIdTextBox.Text) == 0)
            {
                MessageBox.Show("Select An User");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = string.Format(@"DELETE FROM UserInfo WHERE UserId ={0}", Convert.ToInt32(userIdTextBox.Text));
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully");
                sqlCon.Close();
                LoadUsers();
                Reset();
            }
        }
        private void Reset()
        {
            userIdTextBox.Text = 0.ToString();
            usernameTextBox.Text = "";
            contactTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void userGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userIdTextBox.Text = userGridView.Rows[e.RowIndex].Cells["UserId"].Value.ToString();// userIdTextBox.Text is hidden field
            usernameTextBox.Text = userGridView.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            contactTextBox.Text = userGridView.Rows[e.RowIndex].Cells["Contact"].Value.ToString();
            passwordTextBox.Text = userGridView.Rows[e.RowIndex].Cells["UserPassword"].Value.ToString();
        }
    }
}
