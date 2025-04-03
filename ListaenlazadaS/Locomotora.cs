using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ListaenlazadaS
{
    class Locomotora
    {
        Vagon Primero {  get; set; }

        public void AgregaPrimero(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) // caso 1 locomotora sola
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon primVag = this.Primero;

                nuevo.sig = this.Primero;

                this.Primero = nuevo;
              
            }

        }


        public void AgregaFinal(int valor)
      {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) // caso 1 locomotora sola
            {
                this.Primero = nuevo;

            }
            else 
            {
                Vagon tmp = this.Primero;
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
            Vagon tmp = this.Primero;
            while (tmp != null) {
                listaVag += tmp.Dato + ",  ";
                tmp = tmp.sig; 
            }

            return listaVag;
        }

        public void EliminarUltimo()
        {
            if (this.Primero == null) // Caso 1: La lista está vacía
            {
                return;
            }

            if (this.Primero.sig == null) // Caso 2: Solo hay un vagón
            {
                this.Primero = null; 
                return;
            }
          
            Vagon tmp = this.Primero;
            while (tmp.sig.sig != null) // Recorremos hasta el penúltimo vagón
            {
                tmp = tmp.sig;
            }
            tmp.sig = null; // Eliminamos el último vagón
        }

        public int Largo()//identificador de cuantos vagones hay
        {            

            return 0;
        }


        public int GetValor(int pos)//valor a elegir para llevar al final
        {
            return 0;
        }
        public void AgregaLEFinal(Locomotora otro)//llevar al final el valor seleccionado
        {

        }




        public bool ExisteValor (int valor)
        {
            Vagon tmp = this.Primero; //creo una variable temporal que va a recorrer dato por dato
            while(tmp != null)//recorrera la lista hasta que el siguiente sea nul
            {
                if (tmp != null) //si el dato de l variable temporal es igual al valor que buscamos retornara verdadero
                {
                    return true;
                }
                tmp = tmp.sig;//si no es igual al valor que buscamos, la variable temporal se movera al siguiente vagon
            }
            return false;//si no se encuentra el valor retornara falsa
        }

        

    }
}
