namespace Gui_Database
{
    partial class Parking_Space_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parking_Space_UC));
            this.label3 = new System.Windows.Forms.Label();
            this.Search_in_table_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Location_Box = new System.Windows.Forms.TextBox();
            this.Parking_Space_ID_box = new System.Windows.Forms.TextBox();
            this.Show_Account_table_list = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Parking_Space_table_listview = new System.Windows.Forms.ListView();
            this.ParkingSpace_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location_Parking_Space = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Employee_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.Employee_ID_Box = new System.Windows.Forms.TextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(633, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 40);
            this.label3.TabIndex = 53;
            this.label3.Text = "Location";
            // 
            // Search_in_table_btn
            // 
            this.Search_in_table_btn.BackColor = System.Drawing.Color.Black;
            this.Search_in_table_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_in_table_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Search_in_table_btn.Location = new System.Drawing.Point(82, 531);
            this.Search_in_table_btn.Name = "Search_in_table_btn";
            this.Search_in_table_btn.Size = new System.Drawing.Size(202, 45);
            this.Search_in_table_btn.TabIndex = 52;
            this.Search_in_table_btn.Text = "Search";
            this.Search_in_table_btn.UseVisualStyleBackColor = false;
            this.Search_in_table_btn.Click += new System.EventHandler(this.Search_in_table_btn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(633, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 36);
            this.label2.TabIndex = 51;
            this.label2.Text = "Parking Space ID";
            // 
            // Location_Box
            // 
            this.Location_Box.BackColor = System.Drawing.Color.Black;
            this.Location_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Location_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Location_Box.ForeColor = System.Drawing.Color.White;
            this.Location_Box.Location = new System.Drawing.Point(640, 288);
            this.Location_Box.Name = "Location_Box";
            this.Location_Box.Size = new System.Drawing.Size(211, 25);
            this.Location_Box.TabIndex = 50;
            // 
            // Parking_Space_ID_box
            // 
            this.Parking_Space_ID_box.BackColor = System.Drawing.Color.Black;
            this.Parking_Space_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Parking_Space_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Parking_Space_ID_box.ForeColor = System.Drawing.Color.White;
            this.Parking_Space_ID_box.Location = new System.Drawing.Point(640, 194);
            this.Parking_Space_ID_box.Name = "Parking_Space_ID_box";
            this.Parking_Space_ID_box.Size = new System.Drawing.Size(211, 25);
            this.Parking_Space_ID_box.TabIndex = 49;
            // 
            // Show_Account_table_list
            // 
            this.Show_Account_table_list.BackColor = System.Drawing.Color.Black;
            this.Show_Account_table_list.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Account_table_list.ForeColor = System.Drawing.Color.Snow;
            this.Show_Account_table_list.Location = new System.Drawing.Point(575, 531);
            this.Show_Account_table_list.Name = "Show_Account_table_list";
            this.Show_Account_table_list.Size = new System.Drawing.Size(202, 45);
            this.Show_Account_table_list.TabIndex = 48;
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
            this.label1.Location = new System.Drawing.Point(263, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 59);
            this.label1.TabIndex = 47;
            this.label1.Text = "Parking Space Table";
            // 
            // Parking_Space_table_listview
            // 
            this.Parking_Space_table_listview.BackColor = System.Drawing.Color.Black;
            this.Parking_Space_table_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Parking_Space_table_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParkingSpace_ID,
            this.Location_Parking_Space,
            this.Employee_ID});
            this.Parking_Space_table_listview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Parking_Space_table_listview.ForeColor = System.Drawing.Color.White;
            this.Parking_Space_table_listview.GridLines = true;
            this.Parking_Space_table_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Parking_Space_table_listview.HideSelection = false;
            this.Parking_Space_table_listview.Location = new System.Drawing.Point(39, 155);
            this.Parking_Space_table_listview.Name = "Parking_Space_table_listview";
            this.Parking_Space_table_listview.Size = new System.Drawing.Size(535, 257);
            this.Parking_Space_table_listview.TabIndex = 46;
            this.Parking_Space_table_listview.UseCompatibleStateImageBehavior = false;
            this.Parking_Space_table_listview.View = System.Windows.Forms.View.Details;
            // 
            // ParkingSpace_ID
            // 
            this.ParkingSpace_ID.Text = "ParkingSpace ID";
            this.ParkingSpace_ID.Width = 115;
            // 
            // Location_Parking_Space
            // 
            this.Location_Parking_Space.Text = "Location Parking Space";
            this.Location_Parking_Space.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Location_Parking_Space.Width = 197;
            // 
            // Employee_ID
            // 
            this.Employee_ID.Text = "Employee_ID";
            this.Employee_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Employee_ID.Width = 202;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(633, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 40);
            this.label4.TabIndex = 55;
            this.label4.Text = "Employee ID";
            // 
            // Employee_ID_Box
            // 
            this.Employee_ID_Box.BackColor = System.Drawing.Color.Black;
            this.Employee_ID_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Employee_ID_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Employee_ID_Box.ForeColor = System.Drawing.Color.White;
            this.Employee_ID_Box.Location = new System.Drawing.Point(640, 393);
            this.Employee_ID_Box.Name = "Employee_ID_Box";
            this.Employee_ID_Box.Size = new System.Drawing.Size(160, 25);
            this.Employee_ID_Box.TabIndex = 54;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Exit_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit_btn.Location = new System.Drawing.Point(815, 16);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 45);
            this.Exit_btn.TabIndex = 56;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Parking_Space_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Employee_ID_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search_in_table_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Location_Box);
            this.Controls.Add(this.Parking_Space_ID_box);
            this.Controls.Add(this.Show_Account_table_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parking_Space_table_listview);
            this.Name = "Parking_Space_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button Search_in_table_btn;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Location_Box;
        private System.Windows.Forms.TextBox Parking_Space_ID_box;
        public System.Windows.Forms.Button Show_Account_table_list;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Parking_Space_table_listview;
        private System.Windows.Forms.ColumnHeader ParkingSpace_ID;
        private System.Windows.Forms.ColumnHeader Location_Parking_Space;
        private System.Windows.Forms.ColumnHeader Employee_ID;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Employee_ID_Box;
        private System.Windows.Forms.Button Exit_btn;
    }
}
