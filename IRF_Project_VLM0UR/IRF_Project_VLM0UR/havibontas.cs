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

        }

        private void Fr_Click(object sender, EventArgs e)
        {

        }

        private void Ne_Click(object sender, EventArgs e)
        {

        }

        private void Spa_Click(object sender, EventArgs e)
        {

        }

        private void Ol_Click(object sender, EventArgs e)
        {

        }

        private void Ho_Click(object sender, EventArgs e)
        {

        }

        private void Oro_Click(object sender, EventArgs e)
        {

        }

        private void Jap_Click(object sender, EventArgs e)
        {

        }

        private void USA_Click(object sender, EventArgs e)
        {

        }
    }
}
