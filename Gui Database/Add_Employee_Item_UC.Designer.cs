namespace Gui_Database
{
    partial class Add_Employee_Item_UC
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
            this.label1 = new System.Windows.Forms.Label();
            this.Employee_table_listview = new System.Windows.Forms.ListView();
            this.Employee_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProvinceState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostalZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_of_Hire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Branch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.City_box = new System.Windows.Forms.TextBox();
            this.Telephone_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Branch_ID_box = new System.Windows.Forms.TextBox();
            this.Address_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Salary_box = new System.Windows.Forms.TextBox();
            this.Date_Of_Hire_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Postal_Zip_Code_box = new System.Windows.Forms.TextBox();
            this.Province_State_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_Employee_Box = new System.Windows.Forms.TextBox();
            this.Employee_ID_box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Age_box = new System.Windows.Forms.TextBox();
            this.Title_box = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(307, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 59);
            this.label1.TabIndex = 32;
            this.label1.Text = "Employee Table";
            // 
            // Employee_table_listview
            // 
            this.Employee_table_listview.BackColor = System.Drawing.Color.Black;
            this.Employee_table_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Employee_table_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Employee_ID,
            this.Name_Employee,
            this.Address,
            this.City,
            this.ProvinceState,
            this.PostalZipCode,
            this.Telephone,
            this.Date_of_Hire,
            this.Salary,
            this.Title,
            this.Age,
            this.Branch_ID});
            this.Employee_table_listview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Employee_table_listview.ForeColor = System.Drawing.Color.White;
            this.Employee_table_listview.GridLines = true;
            this.Employee_table_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Employee_table_listview.HideSelection = false;
            this.Employee_table_listview.Location = new System.Drawing.Point(0, 62);
            this.Employee_table_listview.Name = "Employee_table_listview";
            this.Employee_table_listview.Size = new System.Drawing.Size(888, 257);
            this.Employee_table_listview.TabIndex = 31;
            this.Employee_table_listview.UseCompatibleStateImageBehavior = false;
            this.Employee_table_listview.View = System.Windows.Forms.View.Details;
            // 
            // Employee_ID
            // 
            this.Employee_ID.Text = "Employee ID";
            this.Employee_ID.Width = 87;
            // 
            // Name_Employee
            // 
            this.Name_Employee.Text = "Name Employee";
            this.Name_Employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Employee.Width = 103;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 108;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.City.Width = 41;
            // 
            // ProvinceState
            // 
            this.ProvinceState.Text = "Province/State";
            this.ProvinceState.Width = 96;
            // 
            // PostalZipCode
            // 
            this.PostalZipCode.Text = "Postal/Zip Code";
            this.PostalZipCode.Width = 56;
            // 
            // Telephone
            // 
            this.Telephone.Text = "Telephone";
            this.Telephone.Width = 73;
            // 
            // Date_of_Hire
            // 
            this.Date_of_Hire.Text = "Date Hire";
            this.Date_of_Hire.Width = 86;
            // 
            // Salary
            // 
            this.Salary.Text = "Salary";
            this.Salary.Width = 50;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 45;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 59;
            // 
            // Branch_ID
            // 
            this.Branch_ID.Text = "Branch ID";
            this.Branch_ID.Width = 71;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(428, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 40);
            this.label10.TabIndex = 69;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(596, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 36);
            this.label11.TabIndex = 68;
            this.label11.Text = "Telephone";
            // 
            // City_box
            // 
            this.City_box.BackColor = System.Drawing.Color.Black;
            this.City_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.City_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.City_box.ForeColor = System.Drawing.Color.White;
            this.City_box.Location = new System.Drawing.Point(426, 521);
            this.City_box.Name = "City_box";
            this.City_box.Size = new System.Drawing.Size(69, 25);
            this.City_box.TabIndex = 67;
            // 
            // Telephone_box
            // 
            this.Telephone_box.BackColor = System.Drawing.Color.Black;
            this.Telephone_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telephone_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Telephone_box.ForeColor = System.Drawing.Color.White;
            this.Telephone_box.Location = new System.Drawing.Point(597, 442);
            this.Telephone_box.Name = "Telephone_box";
            this.Telephone_box.Size = new System.Drawing.Size(217, 25);
            this.Telephone_box.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(599, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 40);
            this.label8.TabIndex = 65;
            this.label8.Text = "Branch ID";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(596, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 36);
            this.label9.TabIndex = 64;
            this.label9.Text = "Address";
            // 
            // Branch_ID_box
            // 
            this.Branch_ID_box.BackColor = System.Drawing.Color.Black;
            this.Branch_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Branch_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Branch_ID_box.ForeColor = System.Drawing.Color.White;
            this.Branch_ID_box.Location = new System.Drawing.Point(597, 517);
            this.Branch_ID_box.Name = "Branch_ID_box";
            this.Branch_ID_box.Size = new System.Drawing.Size(225, 25);
            this.Branch_ID_box.TabIndex = 63;
            // 
            // Address_box
            // 
            this.Address_box.BackColor = System.Drawing.Color.Black;
            this.Address_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Address_box.ForeColor = System.Drawing.Color.White;
            this.Address_box.Location = new System.Drawing.Point(594, 365);
            this.Address_box.Name = "Address_box";
            this.Address_box.Size = new System.Drawing.Size(189, 25);
            this.Address_box.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(278, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 40);
            this.label6.TabIndex = 61;
            this.label6.Text = "Salary";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(1, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 36);
            this.label7.TabIndex = 60;
            this.label7.Text = "Date Hire";
            // 
            // Salary_box
            // 
            this.Salary_box.BackColor = System.Drawing.Color.Black;
            this.Salary_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Salary_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Salary_box.ForeColor = System.Drawing.Color.White;
            this.Salary_box.Location = new System.Drawing.Point(276, 517);
            this.Salary_box.Name = "Salary_box";
            this.Salary_box.Size = new System.Drawing.Size(98, 25);
            this.Salary_box.TabIndex = 59;
            // 
            // Date_Of_Hire_box
            // 
            this.Date_Of_Hire_box.BackColor = System.Drawing.Color.Black;
            this.Date_Of_Hire_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date_Of_Hire_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Date_Of_Hire_box.ForeColor = System.Drawing.Color.White;
            this.Date_Of_Hire_box.Location = new System.Drawing.Point(8, 517);
            this.Date_Of_Hire_box.Name = "Date_Of_Hire_box";
            this.Date_Of_Hire_box.Size = new System.Drawing.Size(211, 25);
            this.Date_Of_Hire_box.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(275, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 40);
            this.label3.TabIndex = 57;
            this.label3.Text = "Postal/Zip Code";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(-2, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 36);
            this.label4.TabIndex = 56;
            this.label4.Text = "Province/State";
            // 
            // Postal_Zip_Code_box
            // 
            this.Postal_Zip_Code_box.BackColor = System.Drawing.Color.Black;
            this.Postal_Zip_Code_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Postal_Zip_Code_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Postal_Zip_Code_box.ForeColor = System.Drawing.Color.White;
            this.Postal_Zip_Code_box.Location = new System.Drawing.Point(273, 446);
            this.Postal_Zip_Code_box.Name = "Postal_Zip_Code_box";
            this.Postal_Zip_Code_box.Size = new System.Drawing.Size(225, 25);
            this.Postal_Zip_Code_box.TabIndex = 55;
            // 
            // Province_State_box
            // 
            this.Province_State_box.BackColor = System.Drawing.Color.Black;
            this.Province_State_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Province_State_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Province_State_box.ForeColor = System.Drawing.Color.White;
            this.Province_State_box.Location = new System.Drawing.Point(5, 446);
            this.Province_State_box.Name = "Province_State_box";
            this.Province_State_box.Size = new System.Drawing.Size(211, 25);
            this.Province_State_box.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(275, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 40);
            this.label5.TabIndex = 53;
            this.label5.Text = "Name Employee";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(-2, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 52;
            this.label2.Text = "Employee_ID";
            // 
            // Name_Employee_Box
            // 
            this.Name_Employee_Box.BackColor = System.Drawing.Color.Black;
            this.Name_Employee_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Employee_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name_Employee_Box.ForeColor = System.Drawing.Color.White;
            this.Name_Employee_Box.Location = new System.Drawing.Point(276, 371);
            this.Name_Employee_Box.Name = "Name_Employee_Box";
            this.Name_Employee_Box.Size = new System.Drawing.Size(192, 25);
            this.Name_Employee_Box.TabIndex = 51;
            // 
            // Employee_ID_box
            // 
            this.Employee_ID_box.BackColor = System.Drawing.Color.Black;
            this.Employee_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Employee_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Employee_ID_box.ForeColor = System.Drawing.Color.White;
            this.Employee_ID_box.Location = new System.Drawing.Point(5, 365);
            this.Employee_ID_box.Name = "Employee_ID_box";
            this.Employee_ID_box.Size = new System.Drawing.Size(211, 25);
            this.Employee_ID_box.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(278, 545);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 40);
            this.label13.TabIndex = 73;
            this.label13.Text = "Age";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(1, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 36);
            this.label14.TabIndex = 72;
            this.label14.Text = "Tilte";
            // 
            // Age_box
            // 
            this.Age_box.BackColor = System.Drawing.Color.Black;
            this.Age_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Age_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Age_box.ForeColor = System.Drawing.Color.White;
            this.Age_box.Location = new System.Drawing.Point(276, 588);
            this.Age_box.Name = "Age_box";
            this.Age_box.Size = new System.Drawing.Size(76, 25);
            this.Age_box.TabIndex = 71;
            // 
            // Title_box
            // 
            this.Title_box.BackColor = System.Drawing.Color.Black;
            this.Title_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Title_box.ForeColor = System.Drawing.Color.White;
            this.Title_box.Location = new System.Drawing.Point(8, 588);
            this.Title_box.Name = "Title_box";
            this.Title_box.Size = new System.Drawing.Size(211, 25);
            this.Title_box.TabIndex = 70;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.Black;
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Add_btn.Location = new System.Drawing.Point(597, 548);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(202, 45);
            this.Add_btn.TabIndex = 74;
            this.Add_btn.Text = "Add To Table";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Add_Employee_Item_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_Database.Properties.Resources.nasa_53884_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Age_box);
            this.Controls.Add(this.Title_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.City_box);
            this.Controls.Add(this.Telephone_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Branch_ID_box);
            this.Controls.Add(this.Address_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Salary_box);
            this.Controls.Add(this.Date_Of_Hire_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Postal_Zip_Code_box);
            this.Controls.Add(this.Province_State_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_Employee_Box);
            this.Controls.Add(this.Employee_ID_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee_table_listview);
            this.Name = "Add_Employee_Item_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.Load += new System.EventHandler(this.Add_Employee_Item_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Employee_table_listview;
        private System.Windows.Forms.ColumnHeader Employee_ID;
        private System.Windows.Forms.ColumnHeader Name_Employee;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader ProvinceState;
        private System.Windows.Forms.ColumnHeader PostalZipCode;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader Date_of_Hire;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Branch_ID;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox City_box;
        private System.Windows.Forms.TextBox Telephone_box;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Branch_ID_box;
        private System.Windows.Forms.TextBox Address_box;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Salary_box;
        private System.Windows.Forms.TextBox Date_Of_Hire_box;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Postal_Zip_Code_box;
        private System.Windows.Forms.TextBox Province_State_box;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_Employee_Box;
        private System.Windows.Forms.TextBox Employee_ID_box;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Age_box;
        private System.Windows.Forms.TextBox Title_box;
        public System.Windows.Forms.Button Add_btn;
    }
}
