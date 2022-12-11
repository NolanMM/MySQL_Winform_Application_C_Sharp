namespace Gui_Database
{
    partial class Accounts_Table_Uc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts_Table_Uc));
            this.Account_table_listview = new System.Windows.Forms.ListView();
            this.Account_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Show_Account_table_list = new System.Windows.Forms.Button();
            this.Account_number_box = new System.Windows.Forms.TextBox();
            this.Customer_ID_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Search_in_table_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Account_table_listview
            // 
            this.Account_table_listview.BackColor = System.Drawing.Color.Black;
            this.Account_table_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_table_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Account_number,
            this.PaymentDate,
            this.PaymentAmount,
            this.Customer_ID});
            this.Account_table_listview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Account_table_listview.ForeColor = System.Drawing.Color.White;
            this.Account_table_listview.GridLines = true;
            this.Account_table_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Account_table_listview.HideSelection = false;
            this.Account_table_listview.Location = new System.Drawing.Point(69, 109);
            this.Account_table_listview.Name = "Account_table_listview";
            this.Account_table_listview.Size = new System.Drawing.Size(727, 257);
            this.Account_table_listview.TabIndex = 0;
            this.Account_table_listview.UseCompatibleStateImageBehavior = false;
            this.Account_table_listview.View = System.Windows.Forms.View.Details;
            // 
            // Account_number
            // 
            this.Account_number.Text = "Account number";
            this.Account_number.Width = 180;
            // 
            // PaymentDate
            // 
            this.PaymentDate.Text = "Payment Date";
            this.PaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaymentDate.Width = 180;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.Text = "Payment Amount";
            this.PaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaymentAmount.Width = 180;
            // 
            // Customer_ID
            // 
            this.Customer_ID.Text = "Customer ID";
            this.Customer_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Customer_ID.Width = 180;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(295, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Accounts Table";
            // 
            // Show_Account_table_list
            // 
            this.Show_Account_table_list.BackColor = System.Drawing.Color.Black;
            this.Show_Account_table_list.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Account_table_list.ForeColor = System.Drawing.Color.Snow;
            this.Show_Account_table_list.Location = new System.Drawing.Point(562, 486);
            this.Show_Account_table_list.Name = "Show_Account_table_list";
            this.Show_Account_table_list.Size = new System.Drawing.Size(202, 45);
            this.Show_Account_table_list.TabIndex = 7;
            this.Show_Account_table_list.Text = "Show the List";
            this.Show_Account_table_list.UseVisualStyleBackColor = false;
            this.Show_Account_table_list.Click += new System.EventHandler(this.Show_Account_table_list_Click);
            // 
            // Account_number_box
            // 
            this.Account_number_box.BackColor = System.Drawing.Color.Black;
            this.Account_number_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_number_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Account_number_box.ForeColor = System.Drawing.Color.White;
            this.Account_number_box.Location = new System.Drawing.Point(69, 418);
            this.Account_number_box.Name = "Account_number_box";
            this.Account_number_box.Size = new System.Drawing.Size(211, 25);
            this.Account_number_box.TabIndex = 8;
            // 
            // Customer_ID_Box
            // 
            this.Customer_ID_Box.BackColor = System.Drawing.Color.Black;
            this.Customer_ID_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_ID_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Customer_ID_Box.ForeColor = System.Drawing.Color.White;
            this.Customer_ID_Box.Location = new System.Drawing.Point(562, 422);
            this.Customer_ID_Box.Name = "Customer_ID_Box";
            this.Customer_ID_Box.Size = new System.Drawing.Size(225, 25);
            this.Customer_ID_Box.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(62, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Account number";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(564, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Customer_ID";
            // 
            // Search_in_table_btn
            // 
            this.Search_in_table_btn.BackColor = System.Drawing.Color.Black;
            this.Search_in_table_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_in_table_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Search_in_table_btn.Location = new System.Drawing.Point(69, 486);
            this.Search_in_table_btn.Name = "Search_in_table_btn";
            this.Search_in_table_btn.Size = new System.Drawing.Size(202, 45);
            this.Search_in_table_btn.TabIndex = 17;
            this.Search_in_table_btn.Text = "Search";
            this.Search_in_table_btn.UseVisualStyleBackColor = false;
            this.Search_in_table_btn.Click += new System.EventHandler(this.Search_in_table_btn_Click);
            // 
            // Accounts_Table_Uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Search_in_table_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Customer_ID_Box);
            this.Controls.Add(this.Account_number_box);
            this.Controls.Add(this.Show_Account_table_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Account_table_listview);
            this.Name = "Accounts_Table_Uc";
            this.Size = new System.Drawing.Size(894, 618);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Account_table_listview;
        private System.Windows.Forms.ColumnHeader Account_number;
        private System.Windows.Forms.ColumnHeader PaymentDate;
        private System.Windows.Forms.ColumnHeader PaymentAmount;
        private System.Windows.Forms.ColumnHeader Customer_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Show_Account_table_list;
        private System.Windows.Forms.TextBox Account_number_box;
        private System.Windows.Forms.TextBox Customer_ID_Box;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button Search_in_table_btn;
    }
}
