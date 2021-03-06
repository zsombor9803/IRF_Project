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
    public partial class HorvatForm : Form
    {
        List<Orszagok> _horvat = new List<Orszagok>();
        public HorvatForm()
        {
            InitializeComponent();
            Beolvas();
            diagram();
        }

        void Beolvas()
        {
            using (StreamReader sr = new StreamReader("Horvatorszag.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    Orszagok orsz = new Orszagok();

                    string[] line = sr.ReadLine().Split(';');
                    orsz.Datum = line[0];
                    orsz.Honap = line[0];
                    orsz.Esetszam = int.Parse(line[1]);

                    _horvat.Add(orsz);
                }
            }
        }

        void diagram()
        {
            dataGridView1.DataSource = _horvat;
            chart1.DataSource = _horvat;

            dataGridView1.Columns[1].Visible = false;

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Datum";
            series.YValueMembers = "esetszam";
            series.IsVisibleInLegend = false;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = true;
        }
    }
}
