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
    public partial class Multheti : Form
    {
        int szam = 0;

        List<Napi> _napi = new List<Napi>();
        public Multheti()
        {
            InitializeComponent();
            Beolvasas();
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
    }
}
