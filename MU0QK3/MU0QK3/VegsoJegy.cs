using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU0QK3
{
    class VegsoJegy
    {
        public int ID { get; set; }
        public string Nev { get; set; }
        private double _osztalyzat;

        public double Osztalyzat
        {
            get { return _osztalyzat; }
            set {
                _osztalyzat = value;
                if (_osztalyzat<1.7)
                {
                    _osztalyzat = 1;
                }
                else if (_osztalyzat>=1.7 && _osztalyzat<2.51)
                {
                    _osztalyzat = 2;
                }
                else if (_osztalyzat>=2.51 && _osztalyzat<3.51)
                {
                    _osztalyzat = 3;
                }
                else if (_osztalyzat>=3.51 && _osztalyzat<4.51)
                {
                    _osztalyzat = 4;
                }
                else
                {
                    _osztalyzat = 5;
                }
            
            }
        }

    }
}
