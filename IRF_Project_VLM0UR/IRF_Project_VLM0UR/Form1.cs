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

        public void aktivgomb() //ide is kell?
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
    }
}
