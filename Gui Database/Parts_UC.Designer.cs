namespace Gui_Database
{
    partial class Parts_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parts_UC));
            this.Search_in_table_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Part_Name_Box = new System.Windows.Forms.TextBox();
            this.Item_ID_box = new System.Windows.Forms.TextBox();
            this.Show_Account_table_list = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Parts_table_listview = new System.Windows.Forms.ListView();
            this.Part_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colour_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descriptions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Search_in_table_btn
            // 
            this.Search_in_table_btn.BackColor = System.Drawing.Color.Black;
            this.Search_in_table_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_in_table_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Search_in_table_btn.Location = new System.Drawing.Point(74, 531);
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
            this.label5.Location = new System.Drawing.Point(569, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 40);
            this.label5.TabIndex = 43;
            this.label5.Text = "Part Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(67, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 42;
            this.label2.Text = "Item ID";
            // 
            // Part_Name_Box
            // 
            this.Part_Name_Box.BackColor = System.Drawing.Color.Black;
            this.Part_Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Part_Name_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Part_Name_Box.ForeColor = System.Drawing.Color.White;
            this.Part_Name_Box.Location = new System.Drawing.Point(567, 467);
            this.Part_Name_Box.Name = "Part_Name_Box";
            this.Part_Name_Box.Size = new System.Drawing.Size(225, 25);
            this.Part_Name_Box.TabIndex = 41;
            // 
            // Item_ID_box
            // 
            this.Item_ID_box.BackColor = System.Drawing.Color.Black;
            this.Item_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Item_ID_box.ForeColor = System.Drawing.Color.White;
            this.Item_ID_box.Location = new System.Drawing.Point(74, 463);
            this.Item_ID_box.Name = "Item_ID_box";
            this.Item_ID_box.Size = new System.Drawing.Size(211, 25);
            this.Item_ID_box.TabIndex = 40;
            // 
            // Show_Account_table_list
            // 
            this.Show_Account_table_list.BackColor = System.Drawing.Color.Black;
            this.Show_Account_table_list.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Account_table_list.ForeColor = System.Drawing.Color.Snow;
            this.Show_Account_table_list.Location = new System.Drawing.Point(567, 531);
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
            this.label1.Location = new System.Drawing.Point(337, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 59);
            this.label1.TabIndex = 38;
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
            this.Parts_table_listview.Location = new System.Drawing.Point(137, 129);
            this.Parts_table_listview.Name = "Parts_table_listview";
            this.Parts_table_listview.Size = new System.Drawing.Size(641, 257);
            this.Parts_table_listview.TabIndex = 37;
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
            // Parts_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Search_in_table_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Part_Name_Box);
            this.Controls.Add(this.Item_ID_box);
            this.Controls.Add(this.Show_Account_table_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parts_table_listview);
            this.Name = "Parts_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Search_in_table_btn;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Part_Name_Box;
        private System.Windows.Forms.TextBox Item_ID_box;
        public System.Windows.Forms.Button Show_Account_table_list;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Parts_table_listview;
        private System.Windows.Forms.ColumnHeader Part_Name;
        private System.Windows.Forms.ColumnHeader Colour_;
        private System.Windows.Forms.ColumnHeader Descriptions;
        private System.Windows.Forms.ColumnHeader Item_ID;
    }
}
