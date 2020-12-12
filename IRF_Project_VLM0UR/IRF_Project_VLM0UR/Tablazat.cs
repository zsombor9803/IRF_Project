using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_VLM0UR
{
    class Tablazat : Label
    {
        public Tablazat()
        {
            Height = 20;
            Width = 90;
            BackColor = Color.LightBlue;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular);
            
        }
    }
}
