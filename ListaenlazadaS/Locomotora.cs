using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaenlazadaS
{
    class Locomotora
    {
        Vagón Primero {  get; set; }

        public void AgregaPrimero(int valor)
        {
            Vagón nuevo = new Vagón(valor);
            if (this.Primero == null) // caso 1 locomotora sola
            {
                this.Primero = nuevo;

            }
            else //caso 2
            {
                Vagón primVag = this.Primero;

                nuevo.sig = this.Primero;

                this.Primero = nuevo;

                
            }

        }


        public void AgregaFinal(int valor)
      {
            Vagón nuevo = new Vagón(valor);
            if (this.Primero == null) // caso 1 locomotora sola
            {
                this.Primero = nuevo;

            }
            else 
            {
                Vagón tmp = this.Primero;
                while (tmp.sig != null)
                {
                    tmp = tmp.sig;

                }
                tmp.sig = nuevo;
            }
       }
        public string VerVagones ()
        {
            string listaVag = "";
            Vagón tmp = this.Primero;
            while (tmp != null) {
                listaVag += tmp.Dato + ",  ";
                tmp = tmp.sig; 
            }

            return listaVag;
        }

    }
}
