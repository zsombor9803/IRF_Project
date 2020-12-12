using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_VLM0UR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void aktivgomb() //Ez ide nekem nem kell
        {
            foreach (var b in this.Controls.OfType<Button>())
            {
                b.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular);
                b.BackColor = Color.LightGray;
            }

            foreach (var t in this.Controls.OfType<Tablazat>())  //ez fölösleges
            {
                t.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular);
            }
        }

        private void Multhet_Click(object sender, EventArgs e)
        {
            Multheti f2 = new Multheti();
            f2.Show();
        }

        private void Eves_Click(object sender, EventArgs e)
        {
            havibontas f3 = new havibontas();
            f3.Show();
        }

        private void Magyar_Click(object sender, EventArgs e)
        {
            MagyarForm mf = new MagyarForm();
            mf.Show();
        }

        private void Francia_Click(object sender, EventArgs e)
        {
            FranciaForm ff = new FranciaForm();
            ff.Show();
        }

        private void Nemet_Click(object sender, EventArgs e)
        {
            NemetForm nf = new NemetForm();
            nf.Show();
        }

        private void Spanyol_Click(object sender, EventArgs e)
        {
            SpanyolForm sf = new SpanyolForm();
            sf.Show();
        }

        private void Olasz_Click(object sender, EventArgs e)
        {
            OlaszForm of = new OlaszForm();
            of.Show();
        }

        private void Horvat_Click(object sender, EventArgs e)
        {
            HorvatForm hf = new HorvatForm();
            hf.Show();
        }

        private void Orosz_Click(object sender, EventArgs e)
        {
            OroszForm orf = new OroszForm();
            orf.Show();
        }

        private void Japan_Click(object sender, EventArgs e)
        {
            JapanForm jf = new JapanForm();
            jf.Show();
        }

        private void USA_Click(object sender, EventArgs e)
        {
            USAForm uf = new USAForm();
            uf.Show();
        }
    }
}
