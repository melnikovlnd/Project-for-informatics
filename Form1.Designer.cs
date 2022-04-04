
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buildGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_2 = new System.Windows.Forms.GroupBox();
            this.checkBox_str = new System.Windows.Forms.CheckBox();
            this.checkBox_sin = new System.Windows.Forms.CheckBox();
            this.checkBox_cos = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_t = new System.Windows.Forms.TextBox();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label_h = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.radioButton_cos = new System.Windows.Forms.RadioButton();
            this.radioButton_sin = new System.Windows.Forms.RadioButton();
            this.radioButton_str = new System.Windows.Forms.RadioButton();
            this.button_add = new System.Windows.Forms.Button();
            this.linkLabel_cos = new System.Windows.Forms.LinkLabel();
            this.button_del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 737);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            legend3.Title = "Легенда";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(18, 21);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Blue;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Cos";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Red;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Sin";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Fuchsia;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Straight";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(834, 710);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Графики";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1451, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildGraphToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(70, 27);
            this.menu1.Text = "Menu";
            this.menu1.MouseEnter += new System.EventHandler(this.menuToolStripMenuItem_MouseEnter);
            // 
            // buildGraphToolStripMenuItem
            // 
            this.buildGraphToolStripMenuItem.Name = "buildGraphToolStripMenuItem";
            this.buildGraphToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.buildGraphToolStripMenuItem.Text = "Build graph";
            this.buildGraphToolStripMenuItem.Click += new System.EventHandler(this.buildGraphToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox_2
            // 
            this.groupBox_2.Controls.Add(this.linkLabel_cos);
            this.groupBox_2.Controls.Add(this.radioButton_str);
            this.groupBox_2.Controls.Add(this.radioButton_sin);
            this.groupBox_2.Controls.Add(this.radioButton_cos);
            this.groupBox_2.Controls.Add(this.checkBox_str);
            this.groupBox_2.Controls.Add(this.checkBox_sin);
            this.groupBox_2.Controls.Add(this.checkBox_cos);
            this.groupBox_2.Location = new System.Drawing.Point(916, 205);
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new System.Drawing.Size(458, 156);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "groupBox2";
            this.groupBox_2.Visible = false;
            // 
            // checkBox_str
            // 
            this.checkBox_str.AutoSize = true;
            this.checkBox_str.Location = new System.Drawing.Point(28, 86);
            this.checkBox_str.Name = "checkBox_str";
            this.checkBox_str.Size = new System.Drawing.Size(79, 20);
            this.checkBox_str.TabIndex = 2;
            this.checkBox_str.Text = "y = kx + t";
            this.checkBox_str.UseVisualStyleBackColor = true;
            // 
            // checkBox_sin
            // 
            this.checkBox_sin.AutoSize = true;
            this.checkBox_sin.Location = new System.Drawing.Point(28, 60);
            this.checkBox_sin.Name = "checkBox_sin";
            this.checkBox_sin.Size = new System.Drawing.Size(75, 20);
            this.checkBox_sin.TabIndex = 1;
            this.checkBox_sin.Text = "y=sin(x)";
            this.checkBox_sin.UseVisualStyleBackColor = true;
            // 
            // checkBox_cos
            // 
            this.checkBox_cos.AutoSize = true;
            this.checkBox_cos.Location = new System.Drawing.Point(28, 34);
            this.checkBox_cos.Name = "checkBox_cos";
            this.checkBox_cos.Size = new System.Drawing.Size(80, 20);
            this.checkBox_cos.TabIndex = 0;
            this.checkBox_cos.Text = "y=cos(x)";
            this.checkBox_cos.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_t);
            this.groupBox3.Controls.Add(this.textBox_k);
            this.groupBox3.Controls.Add(this.textBox_h);
            this.groupBox3.Controls.Add(this.textBox_b);
            this.groupBox3.Controls.Add(this.textBox_a);
            this.groupBox3.Controls.Add(this.label_h);
            this.groupBox3.Controls.Add(this.label_b);
            this.groupBox3.Controls.Add(this.label_a);
            this.groupBox3.Location = new System.Drawing.Point(916, 639);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "t";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "k";
            // 
            // textBox_t
            // 
            this.textBox_t.Location = new System.Drawing.Point(352, 47);
            this.textBox_t.Name = "textBox_t";
            this.textBox_t.Size = new System.Drawing.Size(100, 22);
            this.textBox_t.TabIndex = 7;
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(352, 16);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.Size = new System.Drawing.Size(100, 22);
            this.textBox_k.TabIndex = 6;
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(99, 82);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 22);
            this.textBox_h.TabIndex = 5;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(99, 50);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 22);
            this.textBox_b.TabIndex = 4;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(99, 19);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 22);
            this.textBox_a.TabIndex = 3;
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.Location = new System.Drawing.Point(25, 88);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(52, 16);
            this.label_h.TabIndex = 2;
            this.label_h.Text = "H(step)";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(25, 53);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(42, 16);
            this.label_b.TabIndex = 1;
            this.label_b.Text = "B(To)";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(25, 22);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(51, 16);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "A(from)";
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(916, 391);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(458, 242);
            this.tabControl.TabIndex = 4;
            this.tabControl.Visible = false;
            // 
            // radioButton_cos
            // 
            this.radioButton_cos.AutoSize = true;
            this.radioButton_cos.Location = new System.Drawing.Point(149, 33);
            this.radioButton_cos.Name = "radioButton_cos";
            this.radioButton_cos.Size = new System.Drawing.Size(104, 20);
            this.radioButton_cos.TabIndex = 3;
            this.radioButton_cos.TabStop = true;
            this.radioButton_cos.Text = "radioButton1";
            this.radioButton_cos.UseVisualStyleBackColor = true;
            // 
            // radioButton_sin
            // 
            this.radioButton_sin.AutoSize = true;
            this.radioButton_sin.Location = new System.Drawing.Point(149, 60);
            this.radioButton_sin.Name = "radioButton_sin";
            this.radioButton_sin.Size = new System.Drawing.Size(104, 20);
            this.radioButton_sin.TabIndex = 4;
            this.radioButton_sin.TabStop = true;
            this.radioButton_sin.Text = "radioButton2";
            this.radioButton_sin.UseVisualStyleBackColor = true;
            // 
            // radioButton_str
            // 
            this.radioButton_str.AutoSize = true;
            this.radioButton_str.Location = new System.Drawing.Point(149, 86);
            this.radioButton_str.Name = "radioButton_str";
            this.radioButton_str.Size = new System.Drawing.Size(104, 20);
            this.radioButton_str.TabIndex = 5;
            this.radioButton_str.TabStop = true;
            this.radioButton_str.Text = "radioButton3";
            this.radioButton_str.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(916, 94);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(253, 62);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Add graphic";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // linkLabel_cos
            // 
            this.linkLabel_cos.AutoSize = true;
            this.linkLabel_cos.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel_cos.Location = new System.Drawing.Point(322, 33);
            this.linkLabel_cos.Name = "linkLabel_cos";
            this.linkLabel_cos.Size = new System.Drawing.Size(64, 16);
            this.linkLabel_cos.TabIndex = 6;
            this.linkLabel_cos.TabStop = true;
            this.linkLabel_cos.Text = "y = cos(x)";
            this.linkLabel_cos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel_cos_MouseClick);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(1185, 94);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(189, 62);
            this.button_del.TabIndex = 6;
            this.button_del.Text = "Delete graphic";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 783);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_2;
        private System.Windows.Forms.CheckBox checkBox_sin;
        private System.Windows.Forms.CheckBox checkBox_cos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.ToolStripMenuItem buildGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_str;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_t;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.RadioButton radioButton_str;
        private System.Windows.Forms.RadioButton radioButton_sin;
        private System.Windows.Forms.RadioButton radioButton_cos;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.LinkLabel linkLabel_cos;
        private System.Windows.Forms.Button button_del;
    }
}

