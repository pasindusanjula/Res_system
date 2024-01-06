namespace Final_Project
{
    partial class UserOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.sellerTextBox = new System.Windows.Forms.TextBox();
            this.orderNoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlaceThisOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(12, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "LogOut";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.White;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUsers.Location = new System.Drawing.Point(11, 95);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(106, 44);
            this.btnUsers.TabIndex = 23;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.White;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnItems.Location = new System.Drawing.Point(11, 34);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(106, 44);
            this.btnItems.TabIndex = 18;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Controls.Add(this.qtyTextBox);
            this.panel1.Controls.Add(this.sellerTextBox);
            this.panel1.Controls.Add(this.orderNoTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.orderGridView);
            this.panel1.Controls.Add(this.btnPlaceThisOrder);
            this.panel1.Controls.Add(this.btnViewOrders);
            this.panel1.Controls.Add(this.itemGridView);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(124, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 556);
            this.panel1.TabIndex = 22;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameLabel.Location = new System.Drawing.Point(709, 4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 31);
            this.usernameLabel.TabIndex = 16;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.Red;
            this.labelAmount.Location = new System.Drawing.Point(710, 517);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(45, 23);
            this.labelAmount.TabIndex = 15;
            this.labelAmount.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(549, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Order Amount :";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(705, 152);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(117, 42);
            this.btnAddToCart.TabIndex = 13;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(517, 154);
            this.qtyTextBox.Multiline = true;
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(182, 35);
            this.qtyTextBox.TabIndex = 12;
            this.qtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyTextBox_KeyPress);
            // 
            // sellerTextBox
            // 
            this.sellerTextBox.Location = new System.Drawing.Point(517, 112);
            this.sellerTextBox.Multiline = true;
            this.sellerTextBox.Name = "sellerTextBox";
            this.sellerTextBox.Size = new System.Drawing.Size(304, 35);
            this.sellerTextBox.TabIndex = 11;
            // 
            // orderNoTextBox
            // 
            this.orderNoTextBox.Location = new System.Drawing.Point(517, 70);
            this.orderNoTextBox.Multiline = true;
            this.orderNoTextBox.Name = "orderNoTextBox";
            this.orderNoTextBox.Size = new System.Drawing.Size(304, 35);
            this.orderNoTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(710, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Place Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(458, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qty :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(442, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seller :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(412, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order No :";
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.Category,
            this.UnitPrice,
            this.Qty,
            this.Amount,
            this.ItemId});
            this.orderGridView.Location = new System.Drawing.Point(346, 195);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 51;
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(475, 310);
            this.orderGridView.TabIndex = 5;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.MinimumWidth = 6;
            this.ItemId.Name = "ItemId";
            this.ItemId.Visible = false;
            this.ItemId.Width = 125;
            // 
            // btnPlaceThisOrder
            // 
            this.btnPlaceThisOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlaceThisOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceThisOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceThisOrder.Location = new System.Drawing.Point(243, 511);
            this.btnPlaceThisOrder.Name = "btnPlaceThisOrder";
            this.btnPlaceThisOrder.Size = new System.Drawing.Size(166, 35);
            this.btnPlaceThisOrder.TabIndex = 4;
            this.btnPlaceThisOrder.Text = "Place This Order";
            this.btnPlaceThisOrder.UseVisualStyleBackColor = false;
            this.btnPlaceThisOrder.Click += new System.EventHandler(this.btnPlaceThisOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewOrders.Location = new System.Drawing.Point(9, 511);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(150, 35);
            this.btnViewOrders.TabIndex = 3;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(9, 91);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(331, 414);
            this.itemGridView.TabIndex = 2;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(9, 61);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(331, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.Text = "Category";
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(303, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER ORDER";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(822, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 19;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(870, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 20;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(918, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 21;
            this.gunaControlBox3.Click += new System.EventHandler(this.gunaControlBox3_Click);
            // 
            // UserOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(963, 594);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox sellerTextBox;
        private System.Windows.Forms.TextBox orderNoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.Button btnPlaceThisOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
    }
}