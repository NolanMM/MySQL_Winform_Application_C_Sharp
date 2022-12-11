namespace Gui_Database
{
    partial class Add_Account_Items_UC
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
            this.Account_table_listview = new System.Windows.Forms.ListView();
            this.Account_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Customer_ID_Box = new System.Windows.Forms.TextBox();
            this.Account_number_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Payment_Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Payment_amount_box = new System.Windows.Forms.TextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Time_Execute_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Count_Item_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.Account_table_listview.Location = new System.Drawing.Point(76, 91);
            this.Account_table_listview.MultiSelect = false;
            this.Account_table_listview.Name = "Account_table_listview";
            this.Account_table_listview.Size = new System.Drawing.Size(727, 257);
            this.Account_table_listview.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(288, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Accounts Table";
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.Black;
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(701, 385);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(176, 45);
            this.Add_btn.TabIndex = 23;
            this.Add_btn.Text = "Add To Table";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(275, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 40);
            this.label5.TabIndex = 22;
            this.label5.Text = "Customer_ID";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(27, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Account number";
            // 
            // Customer_ID_Box
            // 
            this.Customer_ID_Box.BackColor = System.Drawing.Color.Black;
            this.Customer_ID_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_ID_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Customer_ID_Box.ForeColor = System.Drawing.Color.White;
            this.Customer_ID_Box.Location = new System.Drawing.Point(273, 523);
            this.Customer_ID_Box.Name = "Customer_ID_Box";
            this.Customer_ID_Box.Size = new System.Drawing.Size(225, 25);
            this.Customer_ID_Box.TabIndex = 20;
            // 
            // Account_number_box
            // 
            this.Account_number_box.BackColor = System.Drawing.Color.Black;
            this.Account_number_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_number_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Account_number_box.ForeColor = System.Drawing.Color.White;
            this.Account_number_box.Location = new System.Drawing.Point(34, 426);
            this.Account_number_box.Name = "Account_number_box";
            this.Account_number_box.Size = new System.Drawing.Size(211, 25);
            this.Account_number_box.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(275, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 36);
            this.label3.TabIndex = 25;
            this.label3.Text = "Payment Date";
            // 
            // Payment_Date
            // 
            this.Payment_Date.BackColor = System.Drawing.Color.Black;
            this.Payment_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Payment_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Payment_Date.ForeColor = System.Drawing.Color.White;
            this.Payment_Date.Location = new System.Drawing.Point(282, 426);
            this.Payment_Date.Name = "Payment_Date";
            this.Payment_Date.Size = new System.Drawing.Size(211, 25);
            this.Payment_Date.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(27, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 36);
            this.label4.TabIndex = 27;
            this.label4.Text = "Payment Amount";
            // 
            // Payment_amount_box
            // 
            this.Payment_amount_box.BackColor = System.Drawing.Color.Black;
            this.Payment_amount_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Payment_amount_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Payment_amount_box.ForeColor = System.Drawing.Color.White;
            this.Payment_amount_box.Location = new System.Drawing.Point(34, 523);
            this.Payment_amount_box.Name = "Payment_amount_box";
            this.Payment_amount_box.Size = new System.Drawing.Size(211, 25);
            this.Payment_amount_box.TabIndex = 26;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Exit_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit_btn.Location = new System.Drawing.Point(816, 17);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 45);
            this.Exit_btn.TabIndex = 30;
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
            this.Time_Execute_box.Location = new System.Drawing.Point(526, 523);
            this.Time_Execute_box.Name = "Time_Execute_box";
            this.Time_Execute_box.ReadOnly = true;
            this.Time_Execute_box.Size = new System.Drawing.Size(179, 25);
            this.Time_Execute_box.TabIndex = 34;
            this.Time_Execute_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(526, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 40);
            this.label6.TabIndex = 33;
            this.label6.Text = "Time Execute";
            // 
            // Count_Item_box
            // 
            this.Count_Item_box.BackColor = System.Drawing.Color.Black;
            this.Count_Item_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Count_Item_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Count_Item_box.ForeColor = System.Drawing.Color.White;
            this.Count_Item_box.Location = new System.Drawing.Point(533, 426);
            this.Count_Item_box.Name = "Count_Item_box";
            this.Count_Item_box.ReadOnly = true;
            this.Count_Item_box.Size = new System.Drawing.Size(152, 25);
            this.Count_Item_box.TabIndex = 32;
            this.Count_Item_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(533, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 40);
            this.label7.TabIndex = 31;
            this.label7.Text = "Count Item";
            // 
            // Add_Account_Items_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_Database.Properties.Resources.nasa_53884_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Time_Execute_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Count_Item_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Payment_amount_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Payment_Date);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Customer_ID_Box);
            this.Controls.Add(this.Account_number_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Account_table_listview);
            this.Name = "Add_Account_Items_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.Load += new System.EventHandler(this.Add_Account_Items_UC_Load);
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
        public System.Windows.Forms.Button Add_btn;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Customer_ID_Box;
        private System.Windows.Forms.TextBox Account_number_box;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Payment_Date;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Payment_amount_box;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.TextBox Time_Execute_box;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Count_Item_box;
        public System.Windows.Forms.Label label7;
    }
}
