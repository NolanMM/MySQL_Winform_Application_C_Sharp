namespace Gui_Database
{
    partial class Add_Parts_Item_UC
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Part_Name_Box = new System.Windows.Forms.TextBox();
            this.Item_ID_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Parts_table_listview = new System.Windows.Forms.ListView();
            this.Part_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colour_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descriptions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.Colour_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Description_box = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(333, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 40);
            this.label5.TabIndex = 49;
            this.label5.Text = "Part Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(61, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 48;
            this.label2.Text = "Item ID";
            // 
            // Part_Name_Box
            // 
            this.Part_Name_Box.BackColor = System.Drawing.Color.Black;
            this.Part_Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Part_Name_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Part_Name_Box.ForeColor = System.Drawing.Color.White;
            this.Part_Name_Box.Location = new System.Drawing.Point(331, 461);
            this.Part_Name_Box.Name = "Part_Name_Box";
            this.Part_Name_Box.Size = new System.Drawing.Size(225, 25);
            this.Part_Name_Box.TabIndex = 47;
            // 
            // Item_ID_box
            // 
            this.Item_ID_box.BackColor = System.Drawing.Color.Black;
            this.Item_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Item_ID_box.ForeColor = System.Drawing.Color.White;
            this.Item_ID_box.Location = new System.Drawing.Point(68, 461);
            this.Item_ID_box.Name = "Item_ID_box";
            this.Item_ID_box.Size = new System.Drawing.Size(211, 25);
            this.Item_ID_box.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(331, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 59);
            this.label1.TabIndex = 45;
            this.label1.Text = "Parts Table";
            // 
            // Parts_table_listview
            // 
            this.Parts_table_listview.BackColor = System.Drawing.Color.Black;
            this.Parts_table_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Parts_table_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Part_Name,
            this.Colour_,
            this.Descriptions,
            this.Item_ID});
            this.Parts_table_listview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Parts_table_listview.ForeColor = System.Drawing.Color.White;
            this.Parts_table_listview.GridLines = true;
            this.Parts_table_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Parts_table_listview.HideSelection = false;
            this.Parts_table_listview.Location = new System.Drawing.Point(131, 115);
            this.Parts_table_listview.Name = "Parts_table_listview";
            this.Parts_table_listview.Size = new System.Drawing.Size(641, 257);
            this.Parts_table_listview.TabIndex = 44;
            this.Parts_table_listview.UseCompatibleStateImageBehavior = false;
            this.Parts_table_listview.View = System.Windows.Forms.View.Details;
            // 
            // Part_Name
            // 
            this.Part_Name.Text = "Part Name";
            this.Part_Name.Width = 128;
            // 
            // Colour_
            // 
            this.Colour_.Text = "Colour";
            this.Colour_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Colour_.Width = 192;
            // 
            // Descriptions
            // 
            this.Descriptions.Text = "Descriptions";
            this.Descriptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Descriptions.Width = 205;
            // 
            // Item_ID
            // 
            this.Item_ID.Text = "Item_ID";
            this.Item_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Item_ID.Width = 104;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(61, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 51;
            this.label3.Text = "Colour";
            // 
            // Colour_box
            // 
            this.Colour_box.BackColor = System.Drawing.Color.Black;
            this.Colour_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Colour_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Colour_box.ForeColor = System.Drawing.Color.White;
            this.Colour_box.Location = new System.Drawing.Point(68, 540);
            this.Colour_box.Name = "Colour_box";
            this.Colour_box.Size = new System.Drawing.Size(211, 25);
            this.Colour_box.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(333, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 36);
            this.label4.TabIndex = 53;
            this.label4.Text = "Description";
            // 
            // Description_box
            // 
            this.Description_box.BackColor = System.Drawing.Color.Black;
            this.Description_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Description_box.ForeColor = System.Drawing.Color.White;
            this.Description_box.Location = new System.Drawing.Point(340, 540);
            this.Description_box.Name = "Description_box";
            this.Description_box.Size = new System.Drawing.Size(211, 25);
            this.Description_box.TabIndex = 52;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.Black;
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Add_btn.Location = new System.Drawing.Point(647, 492);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(202, 45);
            this.Add_btn.TabIndex = 70;
            this.Add_btn.Text = "Add To Table";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Add_Parts_Item_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui_Database.Properties.Resources.nasa_53884_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Description_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Colour_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Part_Name_Box);
            this.Controls.Add(this.Item_ID_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parts_table_listview);
            this.Name = "Add_Parts_Item_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.Load += new System.EventHandler(this.Add_Parts_Item_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Part_Name_Box;
        private System.Windows.Forms.TextBox Item_ID_box;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Parts_table_listview;
        private System.Windows.Forms.ColumnHeader Part_Name;
        private System.Windows.Forms.ColumnHeader Colour_;
        private System.Windows.Forms.ColumnHeader Descriptions;
        private System.Windows.Forms.ColumnHeader Item_ID;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Colour_box;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Description_box;
        public System.Windows.Forms.Button Add_btn;
    }
}
