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
    public partial class havibontas : Form
    {
        List<Havi> _havi = new List<Havi>();
        public havibontas()
        {
            InitializeComponent();
            Beolvasas();
            dataGridView1.DataSource = _havi;
            gridalap();
            diagram();

        }

        void Beolvasas()
        {
            using (StreamReader sr = new StreamReader("havi.csv", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    Havi hv = new Havi();
                    string[] line = sr.ReadLine().Split(';');

                    hv.Honap = line[0];
                    hv.Magyarorszag = int.Parse(line[1]);
                    hv.Franciaorszag = int.Parse(line[2]);
                    hv.Nemetorszag = int.Parse(line[3]);
                    hv.Spanyolorszag = int.Parse(line[4]);
                    hv.Olaszorszag = int.Parse(line[5]);
                    hv.Horvatorszag = int.Parse(line[6]);
                    hv.Oroszorszag = int.Parse(line[7]);
                    hv.Japan = int.Parse(line[8]);
                    hv.USA = int.Parse(line[9]);

                    _havi.Add(hv);
                }               
            }
        }

        void gridalap()
        {
            for (int i = 1; i < 10; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        void diagram()
        {
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = true;
        }

        private void Mo_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi; //mehet sztem külön konstruktorba

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "Magyarországi \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "Magyarorszag";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[1].Visible = true;
        }

        private void Fr_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi;

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "Franciaországi \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "Franciaorszag";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[2].Visible = true;
        }

        private void Ne_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi;

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "Németországi \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "Nemetorszag";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[3].Visible = true;
        }

        private void Spa_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi;

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "Spanyolországi \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "Spanyolorszag";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[4].Visible = true;
        }

        private void Ol_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi;

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "Olaszországi \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "Olaszorszag";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[5].Visible = true;
        }

        private void Ho_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi;

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "Horvátországi \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "Horvatorszag";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[6].Visible = true;
        }

        private void Oro_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi;

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "Oroszországi \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "Oroszorszag";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[7].Visible = true;
        }

        private void Jap_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi;

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "Japán \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "Japan";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[8].Visible = true;
        }

        private void USA_Click(object sender, EventArgs e)
        {
            chart1.DataSource = _havi;

            var series = chart1.Series[0];

            if (radioButton1.Checked)
            {
                series.ChartType = SeriesChartType.Column;
            }
            if (radioButton2.Checked)
            {
                series.ChartType = SeriesChartType.Line;
            }

            series.LegendText = "USA \n esetszámok";

            series.XValueMember = "Honap";
            series.YValueMembers = "USA";
            series.BorderWidth = 2;

            gridalap();
            dataGridView1.Columns[9].Visible = true;
        }
    }
}
