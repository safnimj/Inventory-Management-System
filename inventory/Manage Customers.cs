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
    public partial class Manage_Customers : Form
    {
        public Manage_Customers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void popularate()
        {
            try
            {
                Con.Open();
                string Myqurey = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomerGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void sButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values(" + customerIdTb.Text + ",'" + cusNameTb.Text + "','" + cusPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void Manage_Customers_Load(object sender, EventArgs e)
        {
            popularate();

        }

        private void sButton3_Click(object sender, EventArgs e)
        {
            if (customerIdTb.Text == "")
            {
                MessageBox.Show("Enter the Customer Id");
            }
            else
            {
                Con.Open();
                string Myquary = "delete from CustomerTbl where CusID='" + customerIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(Myquary, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                popularate();
            }
        }

        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIdTb.Text = CustomerGV.SelectedRows[0].Cells[0].Value.ToString();
            cusNameTb.Text = CustomerGV.SelectedRows[0].Cells[1].Value.ToString();
            cusPhoneTb.Text = CustomerGV.SelectedRows[0].Cells[2].Value.ToString();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from OrdersTbl where CustId=" + customerIdTb.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrdersLable.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(TotAmount) from OrdersTbl where CustId=" + customerIdTb.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLable.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select max(OrderDate) from OrdersTbl where CustId=" + customerIdTb.Text + "", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DateLable.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CusName='" + cusNameTb.Text + "',CusPhone='" + cusPhoneTb.Text + "' where CusID='" + customerIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sButton4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
