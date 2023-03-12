namespace inventory
{
    partial class Manage_Customers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cusPhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.cusNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.sButton4 = new Sipaa.Framework.SButton();
            this.sButton3 = new Sipaa.Framework.SButton();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.OrdersLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.AmountLable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sPanel3 = new Sipaa.Framework.SPanel();
            this.DateLable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).BeginInit();
            this.sPanel1.SuspendLayout();
            this.sPanel2.SuspendLayout();
            this.sPanel3.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Customers";
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
            this.panel1.TabIndex = 5;
            // 
            // cusPhoneTb
            // 
            this.cusPhoneTb.BorderColor = System.Drawing.Color.Maroon;
            this.cusPhoneTb.BorderThickness = 5;
            this.cusPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusPhoneTb.DefaultText = "";
            this.cusPhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cusPhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cusPhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusPhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusPhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusPhoneTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhoneTb.ForeColor = System.Drawing.Color.Maroon;
            this.cusPhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusPhoneTb.Location = new System.Drawing.Point(29, 217);
            this.cusPhoneTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cusPhoneTb.Name = "cusPhoneTb";
            this.cusPhoneTb.PasswordChar = '\0';
            this.cusPhoneTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.cusPhoneTb.PlaceholderText = "Customer Phone";
            this.cusPhoneTb.SelectedText = "";
            this.cusPhoneTb.Size = new System.Drawing.Size(281, 42);
            this.cusPhoneTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cusPhoneTb.TabIndex = 20;
            // 
            // cusNameTb
            // 
            this.cusNameTb.BorderColor = System.Drawing.Color.Maroon;
            this.cusNameTb.BorderThickness = 5;
            this.cusNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusNameTb.DefaultText = "";
            this.cusNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cusNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cusNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusNameTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameTb.ForeColor = System.Drawing.Color.Maroon;
            this.cusNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusNameTb.Location = new System.Drawing.Point(29, 167);
            this.cusNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cusNameTb.Name = "cusNameTb";
            this.cusNameTb.PasswordChar = '\0';
            this.cusNameTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.cusNameTb.PlaceholderText = "Customer Name";
            this.cusNameTb.SelectedText = "";
            this.cusNameTb.Size = new System.Drawing.Size(281, 42);
            this.cusNameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cusNameTb.TabIndex = 19;
            // 
            // customerIdTb
            // 
            this.customerIdTb.BorderColor = System.Drawing.Color.Maroon;
            this.customerIdTb.BorderThickness = 5;
            this.customerIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerIdTb.DefaultText = "";
            this.customerIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIdTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdTb.ForeColor = System.Drawing.Color.Maroon;
            this.customerIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIdTb.Location = new System.Drawing.Point(29, 117);
            this.customerIdTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerIdTb.Name = "customerIdTb";
            this.customerIdTb.PasswordChar = '\0';
            this.customerIdTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.customerIdTb.PlaceholderText = "Customer ID";
            this.customerIdTb.SelectedText = "";
            this.customerIdTb.Size = new System.Drawing.Size(281, 42);
            this.customerIdTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.customerIdTb.TabIndex = 18;
            // 
            // CustomerGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.CustomerGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerGV.ColumnHeadersHeight = 40;
            this.CustomerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.CustomerGV.Location = new System.Drawing.Point(317, 117);
            this.CustomerGV.Name = "CustomerGV";
            this.CustomerGV.RowHeadersVisible = false;
            this.CustomerGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.RowTemplate.Height = 35;
            this.CustomerGV.Size = new System.Drawing.Size(451, 281);
            this.CustomerGV.TabIndex = 22;
            this.CustomerGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.CustomerGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.CustomerGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerGV.ThemeStyle.HeaderStyle.Height = 40;
            this.CustomerGV.ThemeStyle.ReadOnly = false;
            this.CustomerGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.CustomerGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerGV.ThemeStyle.RowsStyle.Height = 35;
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(481, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Customers List";
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
            this.sButton4.Location = new System.Drawing.Point(123, 348);
            this.sButton4.Name = "sButton4";
            this.sButton4.Size = new System.Drawing.Size(75, 41);
            this.sButton4.TabIndex = 26;
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
            this.sButton3.Location = new System.Drawing.Point(204, 287);
            this.sButton3.Name = "sButton3";
            this.sButton3.Size = new System.Drawing.Size(75, 30);
            this.sButton3.TabIndex = 25;
            this.sButton3.Text = "Delete";
            this.sButton3.UseVisualStyleBackColor = false;
            this.sButton3.Click += new System.EventHandler(this.sButton3_Click);
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
            this.sButton2.Location = new System.Drawing.Point(123, 287);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(75, 30);
            this.sButton2.TabIndex = 24;
            this.sButton2.Text = "Edit";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
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
            this.sButton1.Location = new System.Drawing.Point(42, 287);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(75, 30);
            this.sButton1.TabIndex = 23;
            this.sButton1.Text = "Add";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 22);
            this.panel2.TabIndex = 27;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.Crimson;
            this.sPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel1.BorderRadius = 6;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.Controls.Add(this.OrdersLable);
            this.sPanel1.Controls.Add(this.label5);
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(160, 404);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(150, 71);
            this.sPanel1.TabIndex = 28;
            // 
            // OrdersLable
            // 
            this.OrdersLable.AutoSize = true;
            this.OrdersLable.BackColor = System.Drawing.Color.Transparent;
            this.OrdersLable.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersLable.ForeColor = System.Drawing.Color.White;
            this.OrdersLable.Location = new System.Drawing.Point(1, 27);
            this.OrdersLable.Name = "OrdersLable";
            this.OrdersLable.Size = new System.Drawing.Size(107, 32);
            this.OrdersLable.TabIndex = 5;
            this.OrdersLable.Text = "Orders";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Orders Count";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel2.BorderRadius = 6;
            this.sPanel2.BorderSize = 0;
            this.sPanel2.Controls.Add(this.AmountLable);
            this.sPanel2.Controls.Add(this.label8);
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(332, 404);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(180, 71);
            this.sPanel2.TabIndex = 29;
            // 
            // AmountLable
            // 
            this.AmountLable.AutoSize = true;
            this.AmountLable.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLable.ForeColor = System.Drawing.Color.White;
            this.AmountLable.Location = new System.Drawing.Point(3, 27);
            this.AmountLable.Name = "AmountLable";
            this.AmountLable.Size = new System.Drawing.Size(117, 32);
            this.AmountLable.TabIndex = 5;
            this.AmountLable.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Orders Amount";
            // 
            // sPanel3
            // 
            this.sPanel3.BackColor = System.Drawing.Color.OliveDrab;
            this.sPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel3.BorderRadius = 6;
            this.sPanel3.BorderSize = 0;
            this.sPanel3.Controls.Add(this.DateLable);
            this.sPanel3.Controls.Add(this.label10);
            this.sPanel3.ForeColor = System.Drawing.Color.White;
            this.sPanel3.Location = new System.Drawing.Point(534, 404);
            this.sPanel3.Name = "sPanel3";
            this.sPanel3.Size = new System.Drawing.Size(145, 71);
            this.sPanel3.TabIndex = 29;
            // 
            // DateLable
            // 
            this.DateLable.AutoSize = true;
            this.DateLable.BackColor = System.Drawing.Color.Transparent;
            this.DateLable.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLable.ForeColor = System.Drawing.Color.White;
            this.DateLable.Location = new System.Drawing.Point(-1, 27);
            this.DateLable.Name = "DateLable";
            this.DateLable.Size = new System.Drawing.Size(77, 32);
            this.DateLable.TabIndex = 5;
            this.DateLable.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Last Order Date";
            // 
            // Manage_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.sPanel3);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sButton4);
            this.Controls.Add(this.sButton3);
            this.Controls.Add(this.sButton2);
            this.Controls.Add(this.sButton1);
            this.Controls.Add(this.CustomerGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cusPhoneTb);
            this.Controls.Add(this.cusNameTb);
            this.Controls.Add(this.customerIdTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Customers";
            this.Load += new System.EventHandler(this.Manage_Customers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            this.sPanel3.ResumeLayout(false);
            this.sPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox cusPhoneTb;
        private Guna.UI2.WinForms.Guna2TextBox cusNameTb;
        private Guna.UI2.WinForms.Guna2TextBox customerIdTb;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerGV;
        private System.Windows.Forms.Label label4;
        private Sipaa.Framework.SButton sButton4;
        private Sipaa.Framework.SButton sButton3;
        private Sipaa.Framework.SButton sButton2;
        private Sipaa.Framework.SButton sButton1;
        private System.Windows.Forms.Panel panel2;
        private Sipaa.Framework.SPanel sPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OrdersLable;
        private Sipaa.Framework.SPanel sPanel2;
        private System.Windows.Forms.Label AmountLable;
        private System.Windows.Forms.Label label8;
        private Sipaa.Framework.SPanel sPanel3;
        private System.Windows.Forms.Label DateLable;
        private System.Windows.Forms.Label label10;
    }
}