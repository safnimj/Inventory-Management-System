using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class MainIn : Form
    {
        public MainIn()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sToggleButton1.Checked == false)
                passTb.PasswordChar = true;
            else
                passTb.PasswordChar = false;
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            uNameTb.Texts = "";
            passTb.Texts = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where Uname='" + uNameTb.Texts + "' and Upassword='" + passTb.Texts + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Worng UserName or Password");
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
