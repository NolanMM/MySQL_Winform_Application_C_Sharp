﻿namespace Gui_Database
{
    partial class Order_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_UC));
            this.Search_in_table_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Customer_ID_Box = new System.Windows.Forms.TextBox();
            this.Order_ID_box = new System.Windows.Forms.TextBox();
            this.Show_Account_table_list = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Order_table_listview = new System.Windows.Forms.ListView();
            this.Order_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditAuthorizationStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Branch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.Branch_ID_box = new System.Windows.Forms.TextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Time_Execute_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Count_Item_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Search_in_table_btn
            // 
            this.Search_in_table_btn.BackColor = System.Drawing.Color.Black;
            this.Search_in_table_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_in_table_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Search_in_table_btn.Location = new System.Drawing.Point(618, 479);
            this.Search_in_table_btn.Name = "Search_in_table_btn";
            this.Search_in_table_btn.Size = new System.Drawing.Size(202, 45);
            this.Search_in_table_btn.TabIndex = 44;
            this.Search_in_table_btn.Text = "Search";
            this.Search_in_table_btn.UseVisualStyleBackColor = false;
            this.Search_in_table_btn.Click += new System.EventHandler(this.Search_in_table_btn_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(76, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 40);
            this.label5.TabIndex = 43;
            this.label5.Text = "Branch ID";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(76, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 36);
            this.label2.TabIndex = 42;
            this.label2.Text = "Order ID";
            // 
            // Customer_ID_Box
            // 
            this.Customer_ID_Box.BackColor = System.Drawing.Color.Black;
            this.Customer_ID_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_ID_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Customer_ID_Box.ForeColor = System.Drawing.Color.White;
            this.Customer_ID_Box.Location = new System.Drawing.Point(641, 444);
            this.Customer_ID_Box.Name = "Customer_ID_Box";
            this.Customer_ID_Box.Size = new System.Drawing.Size(160, 25);
            this.Customer_ID_Box.TabIndex = 41;
            // 
            // Order_ID_box
            // 
            this.Order_ID_box.BackColor = System.Drawing.Color.Black;
            this.Order_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Order_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Order_ID_box.ForeColor = System.Drawing.Color.White;
            this.Order_ID_box.Location = new System.Drawing.Point(83, 444);
            this.Order_ID_box.Name = "Order_ID_box";
            this.Order_ID_box.Size = new System.Drawing.Size(211, 25);
            this.Order_ID_box.TabIndex = 40;
            // 
            // Show_Account_table_list
            // 
            this.Show_Account_table_list.BackColor = System.Drawing.Color.Black;
            this.Show_Account_table_list.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Account_table_list.ForeColor = System.Drawing.Color.Snow;
            this.Show_Account_table_list.Location = new System.Drawing.Point(618, 530);
            this.Show_Account_table_list.Name = "Show_Account_table_list";
            this.Show_Account_table_list.Size = new System.Drawing.Size(202, 45);
            this.Show_Account_table_list.TabIndex = 39;
            this.Show_Account_table_list.Text = "Show the List";
            this.Show_Account_table_list.UseVisualStyleBackColor = false;
            this.Show_Account_table_list.Click += new System.EventHandler(this.Show_Account_table_list_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(339, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 59);
            this.label1.TabIndex = 38;
            this.label1.Text = "Orders Table";
            // 
            // Order_table_listview
            // 
            this.Order_table_listview.BackColor = System.Drawing.Color.Black;
            this.Order_table_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Order_table_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order_ID,
            this.OrderDate,
            this.CreditAuthorizationStatus,
            this.Branch_ID,
            this.Customer_ID});
            this.Order_table_listview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Order_table_listview.ForeColor = System.Drawing.Color.White;
            this.Order_table_listview.GridLines = true;
            this.Order_table_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Order_table_listview.HideSelection = false;
            this.Order_table_listview.Location = new System.Drawing.Point(114, 132);
            this.Order_table_listview.Name = "Order_table_listview";
            this.Order_table_listview.Size = new System.Drawing.Size(697, 257);
            this.Order_table_listview.TabIndex = 37;
            this.Order_table_listview.UseCompatibleStateImageBehavior = false;
            this.Order_table_listview.View = System.Windows.Forms.View.Details;
            // 
            // Order_ID
            // 
            this.Order_ID.Text = "Order_ID";
            this.Order_ID.Width = 77;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Order Date";
            this.OrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderDate.Width = 192;
            // 
            // CreditAuthorizationStatus
            // 
            this.CreditAuthorizationStatus.Text = "Credit Authorization Status";
            this.CreditAuthorizationStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreditAuthorizationStatus.Width = 202;
            // 
            // Branch_ID
            // 
            this.Branch_ID.Text = "Branch ID";
            this.Branch_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Branch_ID.Width = 109;
            // 
            // Customer_ID
            // 
            this.Customer_ID.Text = "Customer ID";
            this.Customer_ID.Width = 102;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(634, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 40);
            this.label3.TabIndex = 45;
            this.label3.Text = "Customer ID";
            // 
            // Branch_ID_box
            // 
            this.Branch_ID_box.BackColor = System.Drawing.Color.Black;
            this.Branch_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Branch_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Branch_ID_box.ForeColor = System.Drawing.Color.White;
            this.Branch_ID_box.Location = new System.Drawing.Point(83, 544);
            this.Branch_ID_box.Name = "Branch_ID_box";
            this.Branch_ID_box.Size = new System.Drawing.Size(160, 25);
            this.Branch_ID_box.TabIndex = 46;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Exit_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit_btn.Location = new System.Drawing.Point(817, 13);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 45);
            this.Exit_btn.TabIndex = 47;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Time_Execute_box
            // 
            this.Time_Execute_box.BackColor = System.Drawing.Color.Black;
            this.Time_Execute_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Time_Execute_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Time_Execute_box.ForeColor = System.Drawing.Color.White;
            this.Time_Execute_box.Location = new System.Drawing.Point(357, 537);
            this.Time_Execute_box.Name = "Time_Execute_box";
            this.Time_Execute_box.ReadOnly = true;
            this.Time_Execute_box.Size = new System.Drawing.Size(179, 25);
            this.Time_Execute_box.TabIndex = 51;
            this.Time_Execute_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(357, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 40);
            this.label4.TabIndex = 50;
            this.label4.Text = "Time Execute";
            // 
            // Count_Item_box
            // 
            this.Count_Item_box.BackColor = System.Drawing.Color.Black;
            this.Count_Item_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Count_Item_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Count_Item_box.ForeColor = System.Drawing.Color.White;
            this.Count_Item_box.Location = new System.Drawing.Point(357, 444);
            this.Count_Item_box.Name = "Count_Item_box";
            this.Count_Item_box.ReadOnly = true;
            this.Count_Item_box.Size = new System.Drawing.Size(152, 25);
            this.Count_Item_box.TabIndex = 49;
            this.Count_Item_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(357, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 40);
            this.label6.TabIndex = 48;
            this.label6.Text = "Count Item";
            // 
            // Order_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Time_Execute_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Count_Item_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Branch_ID_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search_in_table_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Customer_ID_Box);
            this.Controls.Add(this.Order_ID_box);
            this.Controls.Add(this.Show_Account_table_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order_table_listview);
            this.Name = "Order_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Search_in_table_btn;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Customer_ID_Box;
        private System.Windows.Forms.TextBox Order_ID_box;
        public System.Windows.Forms.Button Show_Account_table_list;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Order_table_listview;
        private System.Windows.Forms.ColumnHeader Order_ID;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader CreditAuthorizationStatus;
        private System.Windows.Forms.ColumnHeader Branch_ID;
        private System.Windows.Forms.ColumnHeader Customer_ID;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Branch_ID_box;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.TextBox Time_Execute_box;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Count_Item_box;
        public System.Windows.Forms.Label label6;
    }
}
