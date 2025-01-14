﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FControlAll
{
    public partial class DifficultyAll: UserControl
    {
        public DifficultyAll()
        {
            InitializeComponent();
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void DifficultyAll_Load_1(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            //设置曲线的样式
            Series series = chart1.Series[0];

            //画样条曲线（Spline）
            series.ChartType = SeriesChartType.FastLine;

            //this.chart1.ChartAreas["Chart1"].AxisX.MajorGrid.Enabled = false;
            this.chart1.ChartAreas["Chart1"].AxisY.MajorGrid.Enabled = true;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            this.chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            //50, 70, 20, 60, 10
            List<string> x = new List<string>() { "七星鲁王宫", "西沙海底墓", "秦岭神树", "云顶天宫", "西王母宫", "张家古楼" };
            chart1.ChartAreas["Chart1"].AxisY.Maximum = 100;//设置Y轴最大值
            chart1.ChartAreas["Chart1"].AxisY.Minimum = 0;
            chart1.ChartAreas["Chart1"].AxisY.Interval = 20;//设置每个刻度的跨度
            //List<int> y = new List<int>() { 20, 40, 60, 80, 100 };

            List<int> l1 = new List<int>() { 0, 0, 0, 0, 0, 0 };

            chart1.Series[0].Points.DataBindXY(x, l1);
            //chart1.Series["墓穴2"].Points.DataBindXY(x, l2);
            //chart1.Series["墓穴3"].Points.DataBindXY(x, l3);
            //chart1.Series["墓穴4"].Points.DataBindXY(x, l4);
            //chart1.Series["墓穴5"].Points.DataBindXY(x, l5);


        }
        private void button1_Click_1(object sender, EventArgs e)
        {


            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Height = 140;//困难指数
            progressBar1.Location = new System.Drawing.Point(187, 350);
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkGreen;
            progressBar1.Style = ProgressBarStyle.Marquee;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value++;
                Application.DoEvents();
            }
            progressBar2.Visible = true;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Location = new System.Drawing.Point(262, 126);
            progressBar2.Style = ProgressBarStyle.Marquee;
            progressBar2.Height = 364;//困难指数
            for (int i = 0; i < 100; i++)
            {
                progressBar2.Value++;
                Application.DoEvents();
            }
            progressBar3.Visible = true;
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 100;
            progressBar3.Location = new System.Drawing.Point(337, 207);
            progressBar3.Height = 283;//困难指数
            progressBar3.Style = ProgressBarStyle.Marquee;
            for (int i = 0; i < 100; i++)
            {
                progressBar3.Value++;
                Application.DoEvents();
            }
            progressBar4.Visible = true;
            progressBar4.Minimum = 0;
            progressBar4.Maximum = 100;
            progressBar4.Location = new System.Drawing.Point(415, 173);
            progressBar4.Height = 317;//困难指数
            progressBar4.Style = ProgressBarStyle.Marquee;
            for (int i = 0; i < 100; i++)
            {
                progressBar4.Value++;
                Application.DoEvents();
            }
            progressBar5.Visible = true;
            progressBar5.Minimum = 0;
            progressBar5.Maximum = 100;
            progressBar5.Location = new System.Drawing.Point(490, 264);
            progressBar5.Height = 225;//困难指数
            progressBar5.Style = ProgressBarStyle.Marquee;
            for (int i = 0; i < 100; i++)
            {
                progressBar5.Value++;
                Application.DoEvents();
            }
            progressBar6.Visible = true;
            progressBar6.Minimum = 0;
            progressBar6.Maximum = 100;
            progressBar6.Location = new System.Drawing.Point(569, 388);
            progressBar6.Height = 102;//困难指数
            progressBar6.Style = ProgressBarStyle.Marquee;
            for (int i = 0; i < 100; i++)
            {
                progressBar6.Value++;
                Application.DoEvents();
            }
            //50, 70, 20, 60, 10
            List<string> x = new List<string>() { "七星鲁王宫", "西沙海底墓", "秦岭神树", "云顶天宫", "西王母宫", "张家古楼" };
            chart1.ChartAreas["Chart1"].AxisY.Maximum = 100;//设置Y轴最大值
            chart1.ChartAreas["Chart1"].AxisY.Minimum = 0;
            chart1.ChartAreas["Chart1"].AxisY.Interval = 20;//设置每个刻度的跨度
            //List<int> y = new List<int>() { 20, 40, 60, 80, 100 };

            List<int> l1 = new List<int>() { 45, 92, 74, 81,61, 34 };

            chart1.Series[0].Points.DataBindXY(x, l1);
            //显示数值
            label1.Text = "33";
            label1.Location = new System.Drawing.Point(193, 330);

            label2.Text = "80";
            label2.Location = new System.Drawing.Point(268, 105);

            label3.Text = "62";
            label3.Location = new System.Drawing.Point(342, 187);

            label4.Text = "69";
            label4.Location = new System.Drawing.Point(420, 153);

            label5.Text = "49";
            label5.Location = new System.Drawing.Point(495, 244);

            label6.Text = "22";
            label6.Location = new System.Drawing.Point(574, 368);
        }
        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }
    }
    public class VerticalProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}
