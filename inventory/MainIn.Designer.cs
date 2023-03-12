namespace inventory
{
    partial class MainIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.sToggleButton1 = new Sipaa.Framework.SToggleButton();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.passTb = new Sipaa.Framework.STextBox();
            this.uNameTb = new Sipaa.Framework.STextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sButton2);
            this.panel1.Controls.Add(this.sToggleButton1);
            this.panel1.Controls.Add(this.sButton1);
            this.panel1.Controls.Add(this.passTb);
            this.panel1.Controls.Add(this.uNameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(129, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 393);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(113, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Show Password";
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton2.BorderRadius = 15;
            this.sButton2.BorderSize = 0;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Location = new System.Drawing.Point(102, 343);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(90, 28);
            this.sButton2.TabIndex = 5;
            this.sButton2.Text = "CLEAR";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // sToggleButton1
            // 
            this.sToggleButton1.AutoSize = true;
            this.sToggleButton1.Location = new System.Drawing.Point(68, 308);
            this.sToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.sToggleButton1.Name = "sToggleButton1";
            this.sToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.sToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.sToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.sToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.sToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.sToggleButton1.TabIndex = 4;
            this.sToggleButton1.UseVisualStyleBackColor = true;
            this.sToggleButton1.CheckedChanged += new System.EventHandler(this.sToggleButton1_CheckedChanged);
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 15;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(92, 262);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(110, 40);
            this.sButton1.TabIndex = 3;
            this.sButton1.Text = "LOGIN";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // passTb
            // 
            this.passTb.BackColor = System.Drawing.SystemColors.Window;
            this.passTb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passTb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passTb.BorderRadius = 15;
            this.passTb.BorderSize = 2;
            this.passTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passTb.Location = new System.Drawing.Point(50, 211);
            this.passTb.Margin = new System.Windows.Forms.Padding(4);
            this.passTb.Multiline = false;
            this.passTb.Name = "passTb";
            this.passTb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passTb.PasswordChar = true;
            this.passTb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passTb.PlaceholderText = "";
            this.passTb.Size = new System.Drawing.Size(195, 35);
            this.passTb.TabIndex = 2;
            this.passTb.Tag = "";
            this.passTb.Texts = "";
            this.passTb.UnderlinedStyle = false;
            // 
            // uNameTb
            // 
            this.uNameTb.BackColor = System.Drawing.SystemColors.Window;
            this.uNameTb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.uNameTb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.uNameTb.BorderRadius = 15;
            this.uNameTb.BorderSize = 2;
            this.uNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uNameTb.Location = new System.Drawing.Point(50, 153);
            this.uNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.uNameTb.Multiline = false;
            this.uNameTb.Name = "uNameTb";
            this.uNameTb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.uNameTb.PasswordChar = false;
            this.uNameTb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.uNameTb.PlaceholderText = "";
            this.uNameTb.Size = new System.Drawing.Size(195, 35);
            this.uNameTb.TabIndex = 1;
            this.uNameTb.Texts = "";
            this.uNameTb.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(520, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MainIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(553, 490);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sipaa.Framework.SButton sButton2;
        private Sipaa.Framework.SToggleButton sToggleButton1;
        private Sipaa.Framework.SButton sButton1;
        private Sipaa.Framework.STextBox passTb;
        private Sipaa.Framework.STextBox uNameTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

