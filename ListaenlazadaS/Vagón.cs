using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaenlazadaS
{
    class Vagón
    {
        public int Dato { get; set; }
        public Vagón sig {  get; set; }

        public Vagón(int dato)
        {
            Dato = dato;
        }
        public Vagón()
        {
        }
    }
}
