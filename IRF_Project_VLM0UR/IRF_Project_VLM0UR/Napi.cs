using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_VLM0UR
{
    class Napi
    {
        private int _heti;
        private int _besorolas;

        public int index { get; set; }
        public string Orszag { get; set; }
        public int Hetfo { get; set; }
        public int Kedd { get; set; }
        public int Szerda { get; set; }
        public int Csut { get; set; }
        public int Pentek { get; set; }
        public int Szombat { get; set; }
        public int Vasarnap { get; set; }


        public int Heti
        {
            get { return _heti; }
            set
            {
                _heti = value / 7;
            }
        }

        public int Besorolas
        {
            get { return _besorolas; }
            set
            {

                if (value >= 500)
                {
                    _besorolas = 1;
                }

                if (value <= 100)
                {
                    _besorolas = 2;
                }

                if (value > 100 && value < 500)
                {
                    _besorolas = 3;
                }

            }
        }
    }
}
