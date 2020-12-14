using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IRF_Project_VLM0UR
{
    public partial class Multheti : Form
    {
        int szam = 0;

        List<Napi> _napi = new List<Napi>();
        public Multheti()
        {
            InitializeComponent();
            Beolvasas();
            Tablazatbairas(szam);
            diagram();
        }

        void Beolvasas()
        {
            using (StreamReader sr = new StreamReader("adatok.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    Napi n = new Napi();

                    string[] line = sr.ReadLine().Split(';');
                    n.Orszag = line[0];
                    n.Hetfo = int.Parse(line[1]);
                    n.Kedd = int.Parse(line[2]);
                    n.Szerda = int.Parse(line[3]);
                    n.Csut = int.Parse(line[4]);
                    n.Pentek = int.Parse(line[5]);
                    n.Szombat = int.Parse(line[6]);
                    n.Vasarnap = int.Parse(line[7]);
                    n.Heti = n.Hetfo + n.Kedd + n.Szerda + n.Csut + n.Pentek + n.Szombat + n.Vasarnap;
                    n.Besorolas = n.Hetfo + n.Kedd + n.Szerda + n.Csut + n.Pentek + n.Szombat + n.Vasarnap;

                    _napi.Add(n);
                    szam++;
                }
            }
            szam--;
        }

        void Tablazatbairas(int sor)
        {

            for (int i = 0; i < szam+1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Tablazat t = new Tablazat();
                    t.Top = 40 + i * (t.Height + 5);
                    t.Left = 40 + j * (t.Width + 5);

                    switch (j)
                    {
                        case 0:
                            t.Text = _napi[i].Orszag;
                            break;
                        case 1:
                            t.Text = (_napi[i].Hetfo).ToString();
                            break;
                        case 2:
                            t.Text = (_napi[i].Kedd).ToString();
                            break;
                        case 3:
                            t.Text = (_napi[i].Szerda).ToString();
                            break;
                        case 4:
                            t.Text = (_napi[i].Csut).ToString();
                            break;
                        case 5:
                            t.Text = (_napi[i].Pentek).ToString();
                            break;
                        case 6:
                            t.Text = (_napi[i].Szombat).ToString();
                            break;
                        case 7:
                            t.Text = (_napi[i].Vasarnap).ToString();
                            break;
                        case 8:
                            t.Text = (_napi[i].Heti).ToString();
                            break;
                        case 9:
                            if (_napi[i].Besorolas == 1)
                            {
                                t.Text = "Veszélyes";
                            }
                            if (_napi[i].Besorolas == 2)
                            {
                                t.Text = "Nem veszélyes";
                            }
                            if (_napi[i].Besorolas == 3)
                            {
                                t.Text = "Közepes";
                            }
                            break;
                    }
                    Controls.Add(t);
                }
            }
        }

        public void aktivgomb()
        {
            foreach (var b in this.Controls.OfType<Button>())
            {
                b.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular);
                b.BackColor = Color.LightGray;
            }

            foreach (var t in this.Controls.OfType<Tablazat>())  
            {
                t.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular);
            }
        }

        public void oszlopkiemel(int k)
        {
            foreach (var t in this.Controls.OfType<Tablazat>())
            {
                if (t.Left == (40 + k * (t.Width + 5)))
                {
                    t.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
                }
            }
        }

        void diagram() 
        {
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = true;
        }

        private void H_Click(object sender, EventArgs e)
        {
            aktivgomb();
            H.Font = new Font("Times New Roman", 8.5F, FontStyle.Bold);
            H.BackColor = Color.LightGreen;
            oszlopkiemel(1);

            //diagram
            chart1.DataSource = _napi;
            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Hetfo";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = false;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Pie;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Hetfo";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = true;
            }

            series.IsValueShownAsLabel = true;
        }

        private void K_Click(object sender, EventArgs e)
        {
            aktivgomb();
            K.Font = new Font("Times New Roman", 8.5F, FontStyle.Bold);
            K.BackColor = Color.LightGreen;
            oszlopkiemel(2);

            //diagram
            chart1.DataSource = _napi;
            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Kedd";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = false;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Pie;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Kedd";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = true;
            }

            series.IsValueShownAsLabel = true;
        }

        private void Sze_Click(object sender, EventArgs e)
        {
            aktivgomb();
            Sze.Font = new Font("Times New Roman", 8.5F, FontStyle.Bold);
            Sze.BackColor = Color.LightGreen;
            oszlopkiemel(3);

            //diagram
            chart1.DataSource = _napi;
            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Szerda";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = false;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Pie;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Szerda";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = true;
            }

            series.IsValueShownAsLabel = true;
        }

        private void Cs_Click(object sender, EventArgs e)
        {
            aktivgomb();
            Cs.Font = new Font("Times New Roman", 8.5F, FontStyle.Bold);
            Cs.BackColor = Color.LightGreen;
            oszlopkiemel(4);

            //diagram
            chart1.DataSource = _napi;
            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Csut";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = false;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Pie;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Csut";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = true;
            }

            series.IsValueShownAsLabel = true;
        }

        private void P_Click(object sender, EventArgs e)
        {
            aktivgomb();
            P.Font = new Font("Times New Roman", 8.5F, FontStyle.Bold);
            P.BackColor = Color.LightGreen;
            oszlopkiemel(5);

            //diagram
            chart1.DataSource = _napi;
            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Pentek";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = false;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Pie;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Pentek";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = true;
            }

            series.IsValueShownAsLabel = true;
        }

        private void Szo_Click(object sender, EventArgs e)
        {
            aktivgomb();
            Szo.Font = new Font("Times New Roman", 8.5F, FontStyle.Bold);
            Szo.BackColor = Color.LightGreen;
            oszlopkiemel(6);

            //diagram
            chart1.DataSource = _napi;
            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Szombat";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = false;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Pie;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Szombat";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = true;
            }

            series.IsValueShownAsLabel = true;
        }

        private void V_Click(object sender, EventArgs e)
        {
            aktivgomb();
            V.Font = new Font("Times New Roman", 8.5F, FontStyle.Bold);
            V.BackColor = Color.LightGreen;
            oszlopkiemel(7);

            //diagram
            chart1.DataSource = _napi;
            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Vasarnap";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = false;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Pie;
                series.XValueMember = "Orszag";
                series.YValueMembers = "Vasarnap";
                series.BorderWidth = 2;
                series.IsVisibleInLegend = true;
            }

            series.IsValueShownAsLabel = true;
        }
    }
}
