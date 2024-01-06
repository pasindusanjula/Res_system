using Final_Project.Common;
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
    public partial class ItemsForm : Form
    {
        SqlConnection sqlCon = new SqlConnection(DBCommon.ConString);
        public ItemsForm()
        {
            InitializeComponent();
            usernameLabel.Text = Global.UserInfo.Username;
            LoadItems();
        }
        private void LoadItems()
        {
            sqlCon = CmnMethods.OpenConnectionString(sqlCon);
            string query = "SELECT * FROM Item";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            itemGridView.DataSource = dataSet.Tables[0];
            sqlCon.Close();

            //hide common columns like addeddate,updatedate,updatedby
            itemGridView.Columns[0].Visible = false;
            itemGridView.Columns[5].Visible = false;
            itemGridView.Columns[6].Visible = false;
            itemGridView.Columns[7].Visible = false;
            itemGridView.Columns[8].Visible = false;
        }



        private void ItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            CmnMethods.ResetGlobal();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderForm userOrder = new UserOrderForm();
            userOrder.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (itemCodeTextBox.Text.Trim() == "" || itemNameTextBox.Text.Trim() == "" || categoryComboBox.Text.Trim() == "" || categoryComboBox.Text.Trim() == "Category" || itemPriceTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Fill all fields ");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = @"INSERT INTO Item (ItemCode,ItemName,Category,Price,AddedDate,AddedBy) VALUES (@ItemCode,@ItemName,@Category,@Price,@AddedDate,@AddedBy)";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@ItemCode", itemCodeTextBox.Text.Trim());
                command.Parameters.AddWithValue("@ItemName", itemNameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Category", categoryComboBox.Text.Trim());
                command.Parameters.AddWithValue("@Price", itemPriceTextBox.Text.Trim());
                command.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                command.Parameters.AddWithValue("@AddedBy", Global.UserInfo.UsertId);//Login user ID
                command.ExecuteNonQuery();
                MessageBox.Show("Item Created Successfully ");
                sqlCon.Close();
                LoadItems();
                Reset();
            }

        }
        private void Reset()
        {
            itemIdTextBox.Text = 0.ToString();
            itemCodeTextBox.Text = "";
            itemNameTextBox.Text = "";
            categoryComboBox.Text = "Category";
            itemPriceTextBox.Text = "";
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (itemIdTextBox.Text.Trim() == "" || Convert.ToInt32(itemIdTextBox.Text) == 0)
            {
                MessageBox.Show("Select An Item ");
            }
            else if (itemCodeTextBox.Text.Trim() == "" || itemNameTextBox.Text.Trim() == "" || categoryComboBox.Text.Trim() == "" || categoryComboBox.Text.Trim() == "Category" || itemPriceTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Fill All Fields");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = @"UPDATE Item SET ItemCode = @ItemCode,ItemName = @ItemName ,Category = @Category ,Price = @Price WHERE ItemId = @ItemId ";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@ItemId", itemIdTextBox.Text.Trim());
                command.Parameters.AddWithValue("@ItemCode", itemCodeTextBox.Text.Trim());
                command.Parameters.AddWithValue("@ItemName", itemNameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Category", categoryComboBox.Text.Trim());
                command.Parameters.AddWithValue("@Price", itemPriceTextBox.Text.Trim());
                command.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                command.Parameters.AddWithValue("@UpdatedBy", Global.UserInfo.UsertId);//Login user ID
                command.ExecuteNonQuery();
                MessageBox.Show("Item Update Successfully ");
                sqlCon.Close();
                LoadItems();
                Reset();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (itemIdTextBox.Text.Trim() == "" || Convert.ToInt32(itemIdTextBox.Text) == 0)
            {
                MessageBox.Show("Select An Item");
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = string.Format(@"DELETE FROM Item WHERE ItemId ={0}", Convert.ToInt32(itemIdTextBox.Text));
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.ExecuteNonQuery();
                MessageBox.Show("Item Deleted Successfully");
                sqlCon.Close();
                LoadItems();
                Reset();
            }
        }

        private void itemGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            itemIdTextBox.Text = itemGridView.Rows[e.RowIndex].Cells["ItemId"].Value.ToString();
            itemCodeTextBox.Text = itemGridView.Rows[e.RowIndex].Cells["ItemCode"].Value.ToString();
            itemNameTextBox.Text = itemGridView.Rows[e.RowIndex].Cells["ItemName"].Value.ToString();
            categoryComboBox.Text = itemGridView.Rows[e.RowIndex].Cells["Category"].Value.ToString();
            itemPriceTextBox.Text = itemGridView.Rows[e.RowIndex].Cells["Price"].Value.ToString();
        }
    }
}
