﻿namespace Gui_Database
{
    partial class Add_Skills_UC
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
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Time_Execute_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Count_Item_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Employee_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Skills_table_listview = new System.Windows.Forms.ListView();
            this.Employee_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Skills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.Skills_box = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Exit_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit_btn.Location = new System.Drawing.Point(813, 11);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 45);
            this.Exit_btn.TabIndex = 44;
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
            this.Time_Execute_box.Location = new System.Drawing.Point(576, 466);
            this.Time_Execute_box.Name = "Time_Execute_box";
            this.Time_Execute_box.ReadOnly = true;
            this.Time_Execute_box.Size = new System.Drawing.Size(179, 25);
            this.Time_Execute_box.TabIndex = 43;
            this.Time_Execute_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(576, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 40);
            this.label4.TabIndex = 42;
            this.label4.Text = "Time Execute";
            // 
            // Count_Item_box
            // 
            this.Count_Item_box.BackColor = System.Drawing.Color.Black;
            this.Count_Item_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Count_Item_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Count_Item_box.ForeColor = System.Drawing.Color.White;
            this.Count_Item_box.Location = new System.Drawing.Point(576, 373);
            this.Count_Item_box.Name = "Count_Item_box";
            this.Count_Item_box.ReadOnly = true;
            this.Count_Item_box.Size = new System.Drawing.Size(152, 25);
            this.Count_Item_box.TabIndex = 41;
            this.Count_Item_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(576, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 40);
            this.label3.TabIndex = 40;
            this.label3.Text = "Count Item";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(576, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "Employee_ID";
            // 
            // Employee_box
            // 
            this.Employee_box.BackColor = System.Drawing.Color.Black;
            this.Employee_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Employee_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Employee_box.ForeColor = System.Drawing.Color.White;
            this.Employee_box.Location = new System.Drawing.Point(583, 171);
            this.Employee_box.Name = "Employee_box";
            this.Employee_box.Size = new System.Drawing.Size(211, 25);
            this.Employee_box.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(327, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 59);
            this.label1.TabIndex = 37;
            this.label1.Text = "Skills Table";
            // 
            // Skills_table_listview
            // 
            this.Skills_table_listview.BackColor = System.Drawing.Color.Black;
            this.Skills_table_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Skills_table_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Employee_ID,
            this.Skills});
            this.Skills_table_listview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Skills_table_listview.ForeColor = System.Drawing.Color.White;
            this.Skills_table_listview.GridLines = true;
            this.Skills_table_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Skills_table_listview.HideSelection = false;
            this.Skills_table_listview.Location = new System.Drawing.Point(81, 132);
            this.Skills_table_listview.Name = "Skills_table_listview";
            this.Skills_table_listview.Size = new System.Drawing.Size(369, 257);
            this.Skills_table_listview.TabIndex = 36;
            this.Skills_table_listview.UseCompatibleStateImageBehavior = false;
            this.Skills_table_listview.View = System.Windows.Forms.View.Details;
            // 
            // Employee_ID
            // 
            this.Employee_ID.Text = "Employee ID";
            this.Employee_ID.Width = 180;
            // 
            // Skills
            // 
            this.Skills.Text = "Skills";
            this.Skills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Skills.Width = 180;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(576, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 36);
            this.label5.TabIndex = 46;
            this.label5.Text = "Skills";
            // 
            // Skills_box
            // 
            this.Skills_box.BackColor = System.Drawing.Color.Black;
            this.Skills_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Skills_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Skills_box.ForeColor = System.Drawing.Color.White;
            this.Skills_box.Location = new System.Drawing.Point(583, 264);
            this.Skills_box.Name = "Skills_box";
            this.Skills_box.Size = new System.Drawing.Size(211, 25);
            this.Skills_box.TabIndex = 45;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.Black;
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(172, 418);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(176, 45);
            this.Add_btn.TabIndex = 47;
            this.Add_btn.Text = "Add To Table";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Add_Skills_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_Database.Properties.Resources.nasa_53884_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Skills_box);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Time_Execute_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Count_Item_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Employee_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Skills_table_listview);
            this.Name = "Add_Skills_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.Load += new System.EventHandler(this.Add_Skills_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.TextBox Time_Execute_box;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Count_Item_box;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Employee_box;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Skills_table_listview;
        private System.Windows.Forms.ColumnHeader Employee_ID;
        private System.Windows.Forms.ColumnHeader Skills;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Skills_box;
        public System.Windows.Forms.Button Add_btn;
    }
}
