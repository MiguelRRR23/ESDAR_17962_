using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaenlazadaS
{
    class Vagon
    {
        public int Dato { get; set; }
        public Vagon sig {  get; set; }

        public Vagon(int dato)
        {
            Dato = dato;
        }
        public Vagon()
        {
        }
    }
}
