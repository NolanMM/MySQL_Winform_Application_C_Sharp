namespace Gui_Database
{
    partial class Customer_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_UC));
            this.Customer_table_listview = new System.Windows.Forms.ListView();
            this.Customer_ID_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ProvinceState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostalZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateofBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Primary_Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Branch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Search_in_table_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_Customer_Box = new System.Windows.Forms.TextBox();
            this.Customer_ID_box = new System.Windows.Forms.TextBox();
            this.Show_Account_table_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_table_listview
            // 
            this.Customer_table_listview.BackColor = System.Drawing.Color.Black;
            this.Customer_table_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_table_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Customer_ID_,
            this.Name_Customer,
            this.Address,
            this.City,
            this.ProvinceState,
            this.PostalZipCode,
            this.Telephone,
            this.DateofBirth,
            this.Primary_Language,
            this.Branch_ID});
            this.Customer_table_listview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Customer_table_listview.ForeColor = System.Drawing.Color.White;
            this.Customer_table_listview.GridLines = true;
            this.Customer_table_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Customer_table_listview.HideSelection = false;
            this.Customer_table_listview.Location = new System.Drawing.Point(3, 129);
            this.Customer_table_listview.Name = "Customer_table_listview";
            this.Customer_table_listview.Size = new System.Drawing.Size(888, 257);
            this.Customer_table_listview.TabIndex = 1;
            this.Customer_table_listview.UseCompatibleStateImageBehavior = false;
            this.Customer_table_listview.View = System.Windows.Forms.View.Details;
            // 
            // Customer_ID_
            // 
            this.Customer_ID_.Text = "Customer ID";
            this.Customer_ID_.Width = 87;
            // 
            // Name_Customer
            // 
            this.Name_Customer.Text = "Name Customer";
            this.Name_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Customer.Width = 107;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 122;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.City.Width = 56;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(299, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Table";
            // 
            // ProvinceState
            // 
            this.ProvinceState.Text = "Province/State";
            this.ProvinceState.Width = 102;
            // 
            // PostalZipCode
            // 
            this.PostalZipCode.Text = "Postal/Zip Code";
            this.PostalZipCode.Width = 65;
            // 
            // Telephone
            // 
            this.Telephone.Text = "Telephone";
            this.Telephone.Width = 73;
            // 
            // DateofBirth
            // 
            this.DateofBirth.Text = "Date of Birth";
            this.DateofBirth.Width = 86;
            // 
            // Primary_Language
            // 
            this.Primary_Language.Text = "Primary Language";
            this.Primary_Language.Width = 112;
            // 
            // Branch_ID
            // 
            this.Branch_ID.Text = "Branch ID";
            this.Branch_ID.Width = 68;
            // 
            // Search_in_table_btn
            // 
            this.Search_in_table_btn.BackColor = System.Drawing.Color.Black;
            this.Search_in_table_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_in_table_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Search_in_table_btn.Location = new System.Drawing.Point(83, 529);
            this.Search_in_table_btn.Name = "Search_in_table_btn";
            this.Search_in_table_btn.Size = new System.Drawing.Size(202, 45);
            this.Search_in_table_btn.TabIndex = 28;
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
            this.label5.Location = new System.Drawing.Point(578, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 40);
            this.label5.TabIndex = 27;
            this.label5.Text = "Name Customer";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(76, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Customer_ID";
            // 
            // Name_Customer_Box
            // 
            this.Name_Customer_Box.BackColor = System.Drawing.Color.Black;
            this.Name_Customer_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Customer_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name_Customer_Box.ForeColor = System.Drawing.Color.White;
            this.Name_Customer_Box.Location = new System.Drawing.Point(576, 465);
            this.Name_Customer_Box.Name = "Name_Customer_Box";
            this.Name_Customer_Box.Size = new System.Drawing.Size(225, 25);
            this.Name_Customer_Box.TabIndex = 25;
            // 
            // Customer_ID_box
            // 
            this.Customer_ID_box.BackColor = System.Drawing.Color.Black;
            this.Customer_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Customer_ID_box.ForeColor = System.Drawing.Color.White;
            this.Customer_ID_box.Location = new System.Drawing.Point(83, 461);
            this.Customer_ID_box.Name = "Customer_ID_box";
            this.Customer_ID_box.Size = new System.Drawing.Size(211, 25);
            this.Customer_ID_box.TabIndex = 24;
            // 
            // Show_Account_table_list
            // 
            this.Show_Account_table_list.BackColor = System.Drawing.Color.Black;
            this.Show_Account_table_list.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Account_table_list.ForeColor = System.Drawing.Color.Snow;
            this.Show_Account_table_list.Location = new System.Drawing.Point(576, 529);
            this.Show_Account_table_list.Name = "Show_Account_table_list";
            this.Show_Account_table_list.Size = new System.Drawing.Size(202, 45);
            this.Show_Account_table_list.TabIndex = 23;
            this.Show_Account_table_list.Text = "Show the List";
            this.Show_Account_table_list.UseVisualStyleBackColor = false;
            this.Show_Account_table_list.Click += new System.EventHandler(this.Show_Account_table_list_Click);
            // 
            // Customer_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Search_in_table_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_Customer_Box);
            this.Controls.Add(this.Customer_ID_box);
            this.Controls.Add(this.Show_Account_table_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customer_table_listview);
            this.Name = "Customer_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Customer_table_listview;
        private System.Windows.Forms.ColumnHeader Customer_ID_;
        private System.Windows.Forms.ColumnHeader Name_Customer;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader City;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ProvinceState;
        private System.Windows.Forms.ColumnHeader PostalZipCode;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader DateofBirth;
        private System.Windows.Forms.ColumnHeader Primary_Language;
        private System.Windows.Forms.ColumnHeader Branch_ID;
        public System.Windows.Forms.Button Search_in_table_btn;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_Customer_Box;
        private System.Windows.Forms.TextBox Customer_ID_box;
        public System.Windows.Forms.Button Show_Account_table_list;
    }
}
