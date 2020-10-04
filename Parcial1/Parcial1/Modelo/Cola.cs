using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Modelo
{
    class Cola
    {
        private int tamañoMaximo;
        private int tamañoActual;
        private Nodo inicial;
        private Nodo final;

        public Cola(int tamMaximo)
        {
            inicial = null;
            final = null;
            this.tamañoMaximo = tamMaximo;
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

        public Alumno Busqueda(string apellido)
        {
            Nodo actual;
            actual = inicial;
            if (inicial != null)
            {
                while (actual != null)
                {
                    if (apellido == actual.Alumno.Apellido)
                    {
                        return actual.Alumno;
                    }
                    else
                    {
                        actual = actual.Siguiente;
                    }
                }
            }

            return null;
        }

        public bool IsEmpty()
        {
            return (tamañoActual == 0);
        }

        public bool IsFull()
        {
            return ((tamañoMaximo > 0) && (tamañoMaximo == tamañoActual));
        }

    }
}

