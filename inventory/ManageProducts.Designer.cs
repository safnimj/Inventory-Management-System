namespace inventory
{
    partial class ManageProducts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProPriceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProQtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sButton4 = new Sipaa.Framework.SButton();
            this.sButton3 = new Sipaa.Framework.SButton();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.ProDiscTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.sButton5 = new Sipaa.Framework.SButton();
            this.sButton6 = new Sipaa.Framework.SButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.Maroon;
            this.sButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton2.BorderRadius = 10;
            this.sButton2.BorderSize = 0;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Location = new System.Drawing.Point(81, 395);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(75, 30);
            this.sButton2.TabIndex = 22;
            this.sButton2.Text = "Edit";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 83);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(767, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Mangement System";
            // 
            // ProductGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.ProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductGV.ColumnHeadersHeight = 40;
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.ProductGV.Location = new System.Drawing.Point(237, 148);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersVisible = false;
            this.ProductGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.RowTemplate.Height = 35;
            this.ProductGV.Size = new System.Drawing.Size(551, 324);
            this.ProductGV.TabIndex = 30;
            this.ProductGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.ProductGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.ProductGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductGV.ThemeStyle.HeaderStyle.Height = 40;
            this.ProductGV.ThemeStyle.ReadOnly = false;
            this.ProductGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.ProductGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductGV.ThemeStyle.RowsStyle.Height = 35;
            this.ProductGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.ProductGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // ProPriceTb
            // 
            this.ProPriceTb.BorderColor = System.Drawing.Color.Maroon;
            this.ProPriceTb.BorderThickness = 5;
            this.ProPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProPriceTb.DefaultText = "";
            this.ProPriceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProPriceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProPriceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProPriceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProPriceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProPriceTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPriceTb.ForeColor = System.Drawing.Color.Maroon;
            this.ProPriceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProPriceTb.Location = new System.Drawing.Point(9, 248);
            this.ProPriceTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProPriceTb.Name = "ProPriceTb";
            this.ProPriceTb.PasswordChar = '\0';
            this.ProPriceTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProPriceTb.PlaceholderText = "Price";
            this.ProPriceTb.SelectedText = "";
            this.ProPriceTb.Size = new System.Drawing.Size(222, 42);
            this.ProPriceTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProPriceTb.TabIndex = 29;
            // 
            // ProQtyTb
            // 
            this.ProQtyTb.BorderColor = System.Drawing.Color.Maroon;
            this.ProQtyTb.BorderThickness = 5;
            this.ProQtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProQtyTb.DefaultText = "";
            this.ProQtyTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProQtyTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProQtyTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProQtyTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProQtyTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProQtyTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProQtyTb.ForeColor = System.Drawing.Color.Maroon;
            this.ProQtyTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProQtyTb.Location = new System.Drawing.Point(9, 198);
            this.ProQtyTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProQtyTb.Name = "ProQtyTb";
            this.ProQtyTb.PasswordChar = '\0';
            this.ProQtyTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProQtyTb.PlaceholderText = "Quantity";
            this.ProQtyTb.SelectedText = "";
            this.ProQtyTb.Size = new System.Drawing.Size(222, 42);
            this.ProQtyTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProQtyTb.TabIndex = 28;
            // 
            // ProNameTb
            // 
            this.ProNameTb.BorderColor = System.Drawing.Color.Maroon;
            this.ProNameTb.BorderThickness = 5;
            this.ProNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProNameTb.DefaultText = "";
            this.ProNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProNameTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNameTb.ForeColor = System.Drawing.Color.Maroon;
            this.ProNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProNameTb.Location = new System.Drawing.Point(9, 148);
            this.ProNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProNameTb.Name = "ProNameTb";
            this.ProNameTb.PasswordChar = '\0';
            this.ProNameTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProNameTb.PlaceholderText = "Product Name";
            this.ProNameTb.SelectedText = "";
            this.ProNameTb.Size = new System.Drawing.Size(222, 42);
            this.ProNameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProNameTb.TabIndex = 27;
            // 
            // ProdIdTb
            // 
            this.ProdIdTb.BorderColor = System.Drawing.Color.Maroon;
            this.ProdIdTb.BorderThickness = 5;
            this.ProdIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdIdTb.DefaultText = "";
            this.ProdIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdIdTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIdTb.ForeColor = System.Drawing.Color.Maroon;
            this.ProdIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdIdTb.Location = new System.Drawing.Point(9, 98);
            this.ProdIdTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.PasswordChar = '\0';
            this.ProdIdTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProdIdTb.PlaceholderText = "Product ID";
            this.ProdIdTb.SelectedText = "";
            this.ProdIdTb.Size = new System.Drawing.Size(222, 42);
            this.ProdIdTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdIdTb.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(450, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Product List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 22);
            this.panel2.TabIndex = 25;
            // 
            // sButton4
            // 
            this.sButton4.BackColor = System.Drawing.Color.Maroon;
            this.sButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton4.BorderRadius = 10;
            this.sButton4.BorderSize = 0;
            this.sButton4.FlatAppearance.BorderSize = 0;
            this.sButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton4.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton4.ForeColor = System.Drawing.Color.White;
            this.sButton4.Location = new System.Drawing.Point(81, 431);
            this.sButton4.Name = "sButton4";
            this.sButton4.Size = new System.Drawing.Size(75, 41);
            this.sButton4.TabIndex = 24;
            this.sButton4.Text = "Home";
            this.sButton4.UseVisualStyleBackColor = false;
            this.sButton4.Click += new System.EventHandler(this.sButton4_Click);
            // 
            // sButton3
            // 
            this.sButton3.BackColor = System.Drawing.Color.Maroon;
            this.sButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton3.BorderRadius = 10;
            this.sButton3.BorderSize = 0;
            this.sButton3.FlatAppearance.BorderSize = 0;
            this.sButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton3.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton3.ForeColor = System.Drawing.Color.White;
            this.sButton3.Location = new System.Drawing.Point(156, 395);
            this.sButton3.Name = "sButton3";
            this.sButton3.Size = new System.Drawing.Size(75, 30);
            this.sButton3.TabIndex = 23;
            this.sButton3.Text = "Delete";
            this.sButton3.UseVisualStyleBackColor = false;
            this.sButton3.Click += new System.EventHandler(this.sButton3_Click);
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.Maroon;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 10;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(6, 395);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(75, 30);
            this.sButton1.TabIndex = 21;
            this.sButton1.Text = "Add";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // ProDiscTb
            // 
            this.ProDiscTb.BorderColor = System.Drawing.Color.Maroon;
            this.ProDiscTb.BorderThickness = 5;
            this.ProDiscTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProDiscTb.DefaultText = "";
            this.ProDiscTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProDiscTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProDiscTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProDiscTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProDiscTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProDiscTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProDiscTb.ForeColor = System.Drawing.Color.Maroon;
            this.ProDiscTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProDiscTb.Location = new System.Drawing.Point(9, 298);
            this.ProDiscTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProDiscTb.Name = "ProDiscTb";
            this.ProDiscTb.PasswordChar = '\0';
            this.ProDiscTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProDiscTb.PlaceholderText = "Discription";
            this.ProDiscTb.SelectedText = "";
            this.ProDiscTb.Size = new System.Drawing.Size(222, 42);
            this.ProDiscTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProDiscTb.TabIndex = 31;
            // 
            // CatCombo
            // 
            this.CatCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CatCombo.ForeColor = System.Drawing.Color.Maroon;
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(9, 348);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(222, 28);
            this.CatCombo.TabIndex = 32;
            this.CatCombo.Text = "Product Catogary";
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SearchCombo.ForeColor = System.Drawing.Color.Maroon;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(301, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(222, 28);
            this.SearchCombo.TabIndex = 33;
            this.SearchCombo.Text = "Select Catogary";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            // 
            // sButton5
            // 
            this.sButton5.BackColor = System.Drawing.Color.Maroon;
            this.sButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton5.BorderRadius = 10;
            this.sButton5.BorderSize = 0;
            this.sButton5.FlatAppearance.BorderSize = 0;
            this.sButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton5.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton5.ForeColor = System.Drawing.Color.White;
            this.sButton5.Location = new System.Drawing.Point(526, 110);
            this.sButton5.Name = "sButton5";
            this.sButton5.Size = new System.Drawing.Size(86, 30);
            this.sButton5.TabIndex = 34;
            this.sButton5.Text = "Search";
            this.sButton5.UseVisualStyleBackColor = false;
            this.sButton5.Click += new System.EventHandler(this.sButton5_Click);
            // 
            // sButton6
            // 
            this.sButton6.BackColor = System.Drawing.Color.Maroon;
            this.sButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton6.BorderRadius = 10;
            this.sButton6.BorderSize = 0;
            this.sButton6.FlatAppearance.BorderSize = 0;
            this.sButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton6.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton6.ForeColor = System.Drawing.Color.White;
            this.sButton6.Location = new System.Drawing.Point(615, 110);
            this.sButton6.Name = "sButton6";
            this.sButton6.Size = new System.Drawing.Size(86, 30);
            this.sButton6.TabIndex = 35;
            this.sButton6.Text = "Refresh";
            this.sButton6.UseVisualStyleBackColor = false;
            this.sButton6.Click += new System.EventHandler(this.sButton6_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.sButton6);
            this.Controls.Add(this.sButton5);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.ProDiscTb);
            this.Controls.Add(this.sButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.ProPriceTb);
            this.Controls.Add(this.ProQtyTb);
            this.Controls.Add(this.ProNameTb);
            this.Controls.Add(this.ProdIdTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sButton4);
            this.Controls.Add(this.sButton3);
            this.Controls.Add(this.sButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sipaa.Framework.SButton sButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ProductGV;
        private Guna.UI2.WinForms.Guna2TextBox ProPriceTb;
        private Guna.UI2.WinForms.Guna2TextBox ProQtyTb;
        private Guna.UI2.WinForms.Guna2TextBox ProNameTb;
        private Guna.UI2.WinForms.Guna2TextBox ProdIdTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Sipaa.Framework.SButton sButton4;
        private Sipaa.Framework.SButton sButton3;
        private Sipaa.Framework.SButton sButton1;
        private Guna.UI2.WinForms.Guna2TextBox ProDiscTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.ComboBox SearchCombo;
        private Sipaa.Framework.SButton sButton5;
        private Sipaa.Framework.SButton sButton6;
    }
}