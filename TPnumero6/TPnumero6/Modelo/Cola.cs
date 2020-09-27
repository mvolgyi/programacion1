using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPnumero6.Modelo
{
    public class Cola
    {
        private int tamañoMaximo = 0;
        private int tamañoActual = 0;
        private Nodo inicial;
        private Nodo final;

        public Cola(int tamañomaximo = 0)
        {
            inicial = null;
            final = null;
            this.tamañoMaximo = tamañomaximo;

        }
       

        public void Enqueue(Alumno alumno)
        {
            Nodo nodo = new Nodo(alumno);
            if (inicial == null)
            {
                inicial = nodo;
                inicial.Siguiente = null;
                final = nodo;
                tamañoActual++;
            }
            else
            {
                final.Siguiente = nodo;
                nodo.Siguiente = null;
                final = nodo;
                tamañoActual++;
            }
        }

        public Alumno Dequeue()
        {
            if (inicial != null)
            {
                Alumno dequeueAlumno = inicial.Alumno;
                inicial = inicial.Siguiente;
                tamañoActual--;
                return dequeueAlumno;                
            }
            return null;
        }

        public Alumno Peek()
        {
            if (inicial != null)
            {
                Alumno peekAlumno = inicial.Alumno;
                return peekAlumno;
            }
            return null;
        }

        public bool IsEmpty()
        {
            if (tamañoActual == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            if (tamañoMaximo > 0 && tamañoMaximo == tamañoActual)
                return true;
            else
                return false;

        }
    }
}
