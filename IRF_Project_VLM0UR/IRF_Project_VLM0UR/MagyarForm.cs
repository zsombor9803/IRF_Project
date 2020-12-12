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
    public partial class MagyarForm : Form
    {
        List<Orszagok> _magyar = new List<Orszagok>();
        public MagyarForm()
        {
            InitializeComponent();
            Beolvas();
            diagram();
        }

        void Beolvas()
        {
            using (StreamReader sr = new StreamReader("Magyarorszag.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    Orszagok orsz = new Orszagok();

                    string[] line = sr.ReadLine().Split(';');
                    orsz.Datum = line[0];
                    orsz.Honap = line[0];
                    orsz.Esetszam = int.Parse(line[1]);

                    _magyar.Add(orsz);
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

        private void button1_Click(object sender, EventArgs e)
        {
            var er = from x in _magyar
                     where x.Honap == "Október"
                     select x;


            dataGridView1.DataSource = er.ToList();
            chart1.DataSource = er;

            dataGridView1.Columns[1].Visible = false;

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Datum";
            series.YValueMembers = "esetszam";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var er = from x in _magyar
                     where x.Honap == "November"
                     select x;

            dataGridView1.DataSource = er.ToList();
            chart1.DataSource = er;

            dataGridView1.Columns[1].Visible = false;

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Datum";
            series.YValueMembers = "esetszam";
        }
    }
}
