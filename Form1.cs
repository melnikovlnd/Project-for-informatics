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
        private double a, b, h;
        private double x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void buildGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox_cos.Checked == false && checkBox_sin.Checked == false)
            {
                MessageBox.Show("Выберите хотя бы один график", "Внимание!");
                return;
            }
            if (textBox_a.Text == "" || textBox_b.Text == "" || textBox_h.Text == "")
            {
                MessageBox.Show("Параметры по умолчанию", "Внимание!");
                DefaultParams();
            }
            else
            {
                a = Convert.ToDouble(textBox_a.Text);
                b = Convert.ToDouble(textBox_b.Text);
                h = Convert.ToDouble(textBox_h.Text);
            }

            if (checkBox_cos.Checked)
            {
                x = a;
                this.chart1.Series[0].Points.Clear();
                while (x <= b)
                {
                    y = Math.Cos(x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (checkBox_sin.Checked)
            {
                x = a;
                this.chart1.Series[1].Points.Clear();
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }
        }

        private void menuToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            menu1.ShowDropDown();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox_cos.Checked == false && checkBox_sin.Checked == false)
            {
                MessageBox.Show("Выберите хотя бы один график", "Внимание!");
                return;
            }

            if (checkBox_sin.Checked)
            {
                this.chart1.Series[1].Points.Clear();
            }
            if (checkBox_cos.Checked)
            {
                this.chart1.Series[0].Points.Clear();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DefaultParams()
        {
            a = -10;
            b = 10;
            h = 0.1;
        }
    }
}
