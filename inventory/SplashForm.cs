using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            process1.Value = startpoint;
            if(process1.Value == 100 )
            {
                process1.Value = 0;
                timer1.Stop();
                MainIn home = new MainIn();
                home.Show();
                this.Hide();

            }
        }



        private void process_ValueChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void process_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
