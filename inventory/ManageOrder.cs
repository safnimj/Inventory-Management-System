using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
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
        void populateproducts()
        {

            try
            {
                Con.Open();
                string Myqurey = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        
        void updateproduct()
        {
            
            int id = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            if (newQty < 0)
                MessageBox.Show("Operation Failed");
            else
            {
                Con.Open();
                string query = "update ProductTbl set ProdQty=" + newQty + " where ProdId=" + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateproducts();
            }
        }
        void fillcatogary()
        {
            string query = "select * from CatogariesTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
              //  CatCombo.ValueMember = "CatName";
              //  CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        int num = 0;
        int uprice, totprice, qty;
        string product;

        
        private void ManageOrder_Load(object sender, EventArgs e)
        {
            popularate();
            populateproducts();
            fillcatogary();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UPrice", typeof(int));
            table.Columns.Add("TotPrice", typeof(int));
            OrdersGV.DataSource = table;
        



        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int flag = 0;
        int stock;
        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QtyTb.Text);
            stock = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[3].Value.ToString());
            //totprice = qty * uprice;
            flag = 1;
        }
        DataTable table = new DataTable();
        int sum = 0;
        private void sButton5_Click(object sender, EventArgs e)
        {
            
            if (QtyTb.Text == "")
                MessageBox.Show("Enter the Quentity of Products");
            else if (flag == 0)
                MessageBox.Show("Select the Product");
            else if (Convert.ToInt32(QtyTb.Text) > stock)
                MessageBox.Show("No Enough Stock Available");
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;
                OrdersGV.DataSource = table;
                table.Rows.Add(num, product, qty, uprice, totprice);

                flag = 0;

            }
            sum = sum + totprice;
            totAmount.Text =sum.ToString();
            updateproduct();

        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            if(OrderIdTb.Text==""||customerIdTb.Text==""||CustomerNameTb.Text==""||totAmount.Text=="")
            {
                MessageBox.Show("Fill the Data Correctly");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into OrdersTbl values('" + OrderIdTb.Text + "','" + customerIdTb.Text + "','" + CustomerNameTb.Text + "','" + orderDate.Text + "'," + totAmount.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully");
                Con.Close();
            }
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();

        }

        private void sButton4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIdTb.Text = CustomerGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = CustomerGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myqurey = "select * from ProductTbl where ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
    }
}
