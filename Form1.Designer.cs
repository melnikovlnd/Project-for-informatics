
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_h = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.checkBox_cos = new System.Windows.Forms.CheckBox();
            this.checkBox_sin = new System.Windows.Forms.CheckBox();
            this.buildGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 688);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(18, 21);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Cos";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Sin";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(834, 661);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_sin);
            this.groupBox2.Controls.Add(this.checkBox_cos);
            this.groupBox2.Location = new System.Drawing.Point(916, 548);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 217);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_h);
            this.groupBox3.Controls.Add(this.textBox_b);
            this.groupBox3.Controls.Add(this.textBox_a);
            this.groupBox3.Controls.Add(this.label_h);
            this.groupBox3.Controls.Add(this.label_b);
            this.groupBox3.Controls.Add(this.label_a);
            this.groupBox3.Location = new System.Drawing.Point(916, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 143);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
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
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(25, 53);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(42, 16);
            this.label_b.TabIndex = 1;
            this.label_b.Text = "B(To)";
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
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(99, 16);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 22);
            this.textBox_a.TabIndex = 3;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(99, 50);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 22);
            this.textBox_b.TabIndex = 4;
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(99, 82);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 22);
            this.textBox_h.TabIndex = 5;
            // 
            // checkBox_cos
            // 
            this.checkBox_cos.AutoSize = true;
            this.checkBox_cos.Location = new System.Drawing.Point(99, 43);
            this.checkBox_cos.Name = "checkBox_cos";
            this.checkBox_cos.Size = new System.Drawing.Size(80, 20);
            this.checkBox_cos.TabIndex = 0;
            this.checkBox_cos.Text = "y=cos(x)";
            this.checkBox_cos.UseVisualStyleBackColor = true;
            // 
            // checkBox_sin
            // 
            this.checkBox_sin.AutoSize = true;
            this.checkBox_sin.Location = new System.Drawing.Point(99, 85);
            this.checkBox_sin.Name = "checkBox_sin";
            this.checkBox_sin.Size = new System.Drawing.Size(75, 20);
            this.checkBox_sin.TabIndex = 1;
            this.checkBox_sin.Text = "y=sin(x)";
            this.checkBox_sin.UseVisualStyleBackColor = true;
            // 
            // buildGraphToolStripMenuItem
            // 
            this.buildGraphToolStripMenuItem.Name = "buildGraphToolStripMenuItem";
            this.buildGraphToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.buildGraphToolStripMenuItem.Text = "Build graph";
            this.buildGraphToolStripMenuItem.Click += new System.EventHandler(this.buildGraphToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 783);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}

