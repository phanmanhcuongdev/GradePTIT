using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradePTIT
{
    
    public partial class SplashScreen : Form
    {
        private System.Windows.Forms.Timer timer;
        public SplashScreen()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // 2 giây
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close(); // tự đóng splash
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
