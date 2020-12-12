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
            Tablazatbairas(szam);
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

        void Tablazatbairas(int sor)
        {

            for (int i = 0; i < szam+1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Tablazat t = new Tablazat();
                    t.Top = 40 + i * (t.Height + 5);
                    t.Left = 40 + j * (t.Width + 5);

                    switch (j)
                    {
                        case 0:
                            t.Text = _napi[i].Orszag;
                            break;
                        case 1:
                            t.Text = (_napi[i].Hetfo).ToString();
                            break;
                        case 2:
                            t.Text = (_napi[i].Kedd).ToString();
                            break;
                        case 3:
                            t.Text = (_napi[i].Szerda).ToString();
                            break;
                        case 4:
                            t.Text = (_napi[i].Csut).ToString();
                            break;
                        case 5:
                            t.Text = (_napi[i].Pentek).ToString();
                            break;
                        case 6:
                            t.Text = (_napi[i].Szombat).ToString();
                            break;
                        case 7:
                            t.Text = (_napi[i].Vasarnap).ToString();
                            break;
                        case 8:
                            t.Text = (_napi[i].Heti).ToString();
                            break;
                        case 9:
                            if (_napi[i].Besorolas == 1)
                            {
                                t.Text = "Veszélyes";
                            }
                            if (_napi[i].Besorolas == 2)
                            {
                                t.Text = "Nem veszélyes";
                            }
                            if (_napi[i].Besorolas == 3)
                            {
                                t.Text = "Közepes";
                            }
                            break;
                    }
                    Controls.Add(t);
                }
            }
        }


    }
}
