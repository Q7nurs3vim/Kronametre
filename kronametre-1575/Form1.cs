using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronametre_1575
{
    public partial class Form1 : Form
    {
        int sayac =10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor=Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text=sayac.ToString();
            if(sayac == 0)
            {
                timer1.Stop();
                this.BackColor=Color.Black;
            }
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
