using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_VLM0UR
{
    class bezarogomb : Button
    {
        public bezarogomb()
        {
            Height = 100;
            Width = 100;
            Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            BackColor = Color.Red;
            Click += Bezarogomb_Click;
        }

        private void Bezarogomb_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
