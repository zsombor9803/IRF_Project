﻿using System;
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
    public partial class OlaszForm : Form
    {
        List<Orszagok> _olasz = new List<Orszagok>();
        public OlaszForm()
        {
            InitializeComponent();
            Beolvas();
            diagram();
        }

        void Beolvas()
        {
            using (StreamReader sr = new StreamReader("Olaszország.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    Orszagok orsz = new Orszagok();

                    string[] line = sr.ReadLine().Split(';');
                    orsz.Datum = line[0];
                    orsz.Honap = line[0];
                    orsz.Esetszam = int.Parse(line[1]);

                    _olasz.Add(orsz);
                }
            }
        }

        void diagram()
        {
            dataGridView1.DataSource = _olasz;
            chart1.DataSource = _olasz;

            dataGridView1.Columns[1].Visible = false;

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Datum";
            series.YValueMembers = "esetszam";

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = true;
        }
    }
}
