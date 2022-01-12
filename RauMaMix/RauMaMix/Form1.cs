using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RauMaMix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startPros = 2;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPros += 1;
            myProgress.Value = startPros;
            lblPhantram.Text = startPros + "%";
            if (myProgress.Value == 100)
            {
                myProgress.Value = 1;
                timer1.Stop();
                fLogin login = new fLogin();
                login.Show();
                this.Hide();

            }
        }

        private void myProgress_Click(object sender, EventArgs e)
        {


        }
    }
}
