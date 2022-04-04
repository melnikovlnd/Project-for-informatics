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
        private double a, b, h, k, t;
        private double x, y;
        private int n = 0;
        private TabPage page;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            tabControl.Visible = true;
            groupBox_2.Visible = true;
        }

        private void linkLabel_cos_MouseClick(object sender, MouseEventArgs e)
        {
            page = new TabPage("График " + Convert.ToString(n + 1));
            TextBox box_a = new TextBox();
            tabControl.TabPages.Add(page);
            page.Controls.Add(box_a);
            n++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                tabControl.TabPages.Remove(tabControl.SelectedTab);
                n--;
            }
        }

        private void buildGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox_cos.Checked == false && checkBox_sin.Checked == false && checkBox_str.Checked == false)
            {
                MessageBox.Show("Выберите хотя бы один график", "Внимание!");
                return;
            }
            if (textBox_a.Text == "" || textBox_b.Text == "" || textBox_h.Text == "" || textBox_k.Text == "" || textBox_t.Text == "")
            {
                MessageBox.Show("Параметры по умолчанию", "Внимание!");
                DefaultParams();
            }
            else
            {
                a = Convert.ToDouble(textBox_a.Text);
                b = Convert.ToDouble(textBox_b.Text);
                h = Convert.ToDouble(textBox_h.Text);
                k = Convert.ToDouble(textBox_k.Text);
                t = Convert.ToDouble(textBox_t.Text);
            }

            if (checkBox_cos.Checked)
            {
                this.chart1.Series[0].IsVisibleInLegend = true;
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
                this.chart1.Series[1].IsVisibleInLegend = true;
                x = a;
                this.chart1.Series[1].Points.Clear();
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }

            if (checkBox_str.Checked)
            {
                this.chart1.Series[2].IsVisibleInLegend = true;
                x = a;
                this.chart1.Series[2].Points.Clear();
                while (x <= b)
                {
                    y = k * x + t;
                    this.chart1.Series[2].Points.AddXY(x, y);
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

            if (checkBox_cos.Checked)
            {
                this.chart1.Series[0].IsVisibleInLegend = false;
                this.chart1.Series[0].Points.Clear();
            }
            if (checkBox_sin.Checked)
            {
                this.chart1.Series[1].IsVisibleInLegend = false;
                this.chart1.Series[1].Points.Clear();
            }
            if (checkBox_str.Checked)
            {
                this.chart1.Series[2].IsVisibleInLegend = false;
                this.chart1.Series[2].Points.Clear();
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
            k = 5;
            t = 0;
        }
    }
}
