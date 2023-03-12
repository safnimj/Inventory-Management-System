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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populateOrders()
        {

            try
            {
                Con.Open();
                string Myqurey = "select * from OrdersTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary",new Font ("Century",25,FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Order ID: " + OrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Customer ID: " + OrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 140));
            e.Graphics.DrawString("Customer Name: " + OrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 180));
            e.Graphics.DrawString("Order Date: " + OrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 220));
            e.Graphics.DrawString("Totel Amount: " + OrdersGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 260));
            e.Graphics.DrawString("Thank You", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230,350));

        }
    }
}
