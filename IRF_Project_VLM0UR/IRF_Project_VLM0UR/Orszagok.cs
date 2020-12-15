using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_VLM0UR
{
    class Orszagok
    {
        private string _honap;
        public string Datum { get; set; }
        public string Honap
        {
            get { return _honap; }
            set
            {
                if ((value[6].ToString() == "1") && (value[7].ToString() == "0")) 
                {
                    _honap = "Október";
                }
                if ((value[6].ToString() == "1") && (value[7].ToString() == "1"))
                {
                    _honap = "November";
                }
            }

        }
        public int Esetszam { get; set; }
    }
}
