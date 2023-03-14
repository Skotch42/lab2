using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.05;
        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {

            double rate = (double)numericUpDown2.Value;
            double rate2 = (double)numericUpDown3.Value;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            i = 1;
            chart1.Series[0].Points.AddXY(0, rate);
            chart1.Series[1].Points.AddXY(0, rate2);

            timer1.Start();
        }

        int i = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            double rate = (double)numericUpDown2.Value;
            double rate2 = (double)numericUpDown3.Value;

            rate = rate * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(i, rate);

            rate2 = rate2 * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[1].Points.AddXY(i, rate2);

            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
