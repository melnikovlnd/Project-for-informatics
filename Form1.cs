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
        private TextBox box_a, box_b, box_h, box_k, box_t;
        private string name_graph;


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
            page.Tag = "cos";
            tabControl.TabPages.Add(page);

            string name = "cos";
            box_a = new TextBox();
            box_b = new TextBox();
            box_h = new TextBox();
            Label lab_a = new Label();
            Label lab_b = new Label();
            Label lab_h = new Label();


            lab_a.Text = "A (from) = ";
            lab_a.Location = new Point(10, 10);
            lab_b.Text = "B (to) = ";
            lab_b.Location = new Point(10, 50);
            lab_h.Text = "H (step) = ";
            lab_h.Location = new Point(10, 90);


            box_a.Location = new Point(70, 7);
            box_b.Location = new Point(70, 47);
            box_h.Location = new Point(70, 87);


            page.Controls.Add(box_a);
            page.Controls.Add(box_b);
            page.Controls.Add(box_h);
            page.Controls.Add(lab_a);
            page.Controls.Add(lab_b);
            page.Controls.Add(lab_h);
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
            if (n <= 0)
            {
                MessageBox.Show("Выберите хотя бы один график", "Внимание!");
                return;
            }
            if (box_a.Text == "" || box_b.Text == "" || box_h.Text == "")
            {
                MessageBox.Show("Параметры по умолчанию", "Внимание!");
                DefaultParams();
            }
            else
            {
                a = Convert.ToDouble(box_a.Text);
                b = Convert.ToDouble(box_b.Text);
                h = Convert.ToDouble(box_h.Text);
            }

            if (tabControl.SelectedTab.Tag == "cos")
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

            if (tabControl.SelectedTab.Tag == "cos")
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
