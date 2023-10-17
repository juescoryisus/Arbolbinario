using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbolbinario
{
    class Arbol_binario_de_busqueda
    {

        private Nodo raiz;
        private Nodo trabajo;

        private int i = 0;
        public Arbol_binario_de_busqueda()
        {
            raiz = null;
        }
        internal Nodo Raiz { get => raiz; set => raiz = value; }


        //insertar
        public Nodo Insertar(int pDato, Nodo pNodo)
        {
            Nodo temp = null;

            //si no hay a quien insertar entonces creamos el nodo
            if (pNodo== null)
            {
                temp = new Nodo();
                temp.Dato = pDato;

                return temp;
            }
            if(pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
            }
            if (pDato > pNodo.Dato)
            {
                pNodo.Der = Insertar(pDato, pNodo.Der);
            }
            return pNodo;
        }

        //Transversa 
        public void Transversa(Nodo pNodo)
        {
            if (pNodo == null)
                return;

            // Me proceseo primero a mi 
            for (int n = 0; n < 1; n++)
                Console.Write("  ");

            Console.WriteLine(pNodo.Dato);

            // Si tengo izquierda, proceso a la izquierda 
            if (pNodo.Izq !=null)
            {
                i++;
                Console.Write("I");
                Transversa(pNodo.Izq);
                i--;
            }
            // Si tengo dertecha, proceso a la derecha 
            if (pNodo.Der != null)
            {
                i++;
                Console.Write("D");
                Transversa(pNodo.Der);
                i--;
            }
        }

    }
}
