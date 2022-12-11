namespace Gui_Database
{
    partial class branch_Table_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(branch_Table_UC));
            this.Account_table_listview = new System.Windows.Forms.ListView();
            this.Branch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Branch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supply_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Show_Account_table_list = new System.Windows.Forms.Button();
            this.Search_in_table_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Supply_ID_Box = new System.Windows.Forms.TextBox();
            this.Branch_ID_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Account_table_listview
            // 
            this.Account_table_listview.BackColor = System.Drawing.Color.Black;
            this.Account_table_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_table_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Branch_ID,
            this.Name_Branch,
            this.Location,
            this.Supply_ID});
            this.Account_table_listview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Account_table_listview.ForeColor = System.Drawing.Color.White;
            this.Account_table_listview.GridLines = true;
            this.Account_table_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Account_table_listview.HideSelection = false;
            this.Account_table_listview.Location = new System.Drawing.Point(92, 123);
            this.Account_table_listview.Name = "Account_table_listview";
            this.Account_table_listview.Size = new System.Drawing.Size(727, 257);
            this.Account_table_listview.TabIndex = 1;
            this.Account_table_listview.UseCompatibleStateImageBehavior = false;
            this.Account_table_listview.View = System.Windows.Forms.View.Details;
            // 
            // Branch_ID
            // 
            this.Branch_ID.Text = "Branch ID";
            this.Branch_ID.Width = 180;
            // 
            // Name_Branch
            // 
            this.Name_Branch.Text = "Name Branch";
            this.Name_Branch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Branch.Width = 180;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Location.Width = 180;
            // 
            // Supply_ID
            // 
            this.Supply_ID.Text = "Supply ID";
            this.Supply_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Supply_ID.Width = 180;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(328, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Branch Table";
            // 
            // Show_Account_table_list
            // 
            this.Show_Account_table_list.BackColor = System.Drawing.Color.Black;
            this.Show_Account_table_list.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Account_table_list.ForeColor = System.Drawing.Color.Snow;
            this.Show_Account_table_list.Location = new System.Drawing.Point(585, 511);
            this.Show_Account_table_list.Name = "Show_Account_table_list";
            this.Show_Account_table_list.Size = new System.Drawing.Size(202, 45);
            this.Show_Account_table_list.TabIndex = 8;
            this.Show_Account_table_list.Text = "Show the List";
            this.Show_Account_table_list.UseVisualStyleBackColor = false;
            this.Show_Account_table_list.Click += new System.EventHandler(this.Show_Account_table_list_Click);
            // 
            // Search_in_table_btn
            // 
            this.Search_in_table_btn.BackColor = System.Drawing.Color.Black;
            this.Search_in_table_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_in_table_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Search_in_table_btn.Location = new System.Drawing.Point(92, 511);
            this.Search_in_table_btn.Name = "Search_in_table_btn";
            this.Search_in_table_btn.Size = new System.Drawing.Size(202, 45);
            this.Search_in_table_btn.TabIndex = 22;
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
            this.label5.Location = new System.Drawing.Point(587, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 40);
            this.label5.TabIndex = 21;
            this.label5.Text = "Supply ID";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(85, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "Branch ID";
            // 
            // Supply_ID_Box
            // 
            this.Supply_ID_Box.BackColor = System.Drawing.Color.Black;
            this.Supply_ID_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Supply_ID_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Supply_ID_Box.ForeColor = System.Drawing.Color.White;
            this.Supply_ID_Box.Location = new System.Drawing.Point(585, 447);
            this.Supply_ID_Box.Name = "Supply_ID_Box";
            this.Supply_ID_Box.Size = new System.Drawing.Size(225, 25);
            this.Supply_ID_Box.TabIndex = 19;
            // 
            // Branch_ID_box
            // 
            this.Branch_ID_box.BackColor = System.Drawing.Color.Black;
            this.Branch_ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Branch_ID_box.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.Branch_ID_box.ForeColor = System.Drawing.Color.White;
            this.Branch_ID_box.Location = new System.Drawing.Point(92, 443);
            this.Branch_ID_box.Name = "Branch_ID_box";
            this.Branch_ID_box.Size = new System.Drawing.Size(211, 25);
            this.Branch_ID_box.TabIndex = 18;
            // 
            // branch_Table_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Search_in_table_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Supply_ID_Box);
            this.Controls.Add(this.Branch_ID_box);
            this.Controls.Add(this.Show_Account_table_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Account_table_listview);
            this.Name = "branch_Table_UC";
            this.Size = new System.Drawing.Size(894, 618);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Account_table_listview;
        private System.Windows.Forms.ColumnHeader Branch_ID;
        private System.Windows.Forms.ColumnHeader Name_Branch;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader Supply_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Show_Account_table_list;
        public System.Windows.Forms.Button Search_in_table_btn;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Supply_ID_Box;
        private System.Windows.Forms.TextBox Branch_ID_box;
    }
}
