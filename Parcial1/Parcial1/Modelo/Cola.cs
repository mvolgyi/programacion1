using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Modelo
{
    class Cola
    {
        private int tamMax;
        private int tamActual;
        private Nodo inicial;
        private Nodo final;

        public Cola(int tamMax)
        {
            inicial = null;
            final = null;
            this.tamActual = tamMax;
        }

        public void Enqueue(Alumno alumno)
        {
            Nodo nodo = new Nodo(alumno);
            if (inicial == null)
            {
                inicial = nodo;
                inicial.Siguiente = null;
                final = nodo;
                tamActual++;
            }
            else
            {
                final.Siguiente = nodo;
                nodo.Siguiente = null;
                final = nodo;
                tamActual++;
            }

        }

        public Alumno Dequeue()
        {
            if (inicial != null)
            {
                Alumno dequeueAlumno = inicial.Alumno;
                inicial = inicial.Siguiente;
                tamActual--;
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
            return (tamActual == 0);
        }

        public bool IsFull()
        {
            return (tamMax > 0 && tamMax == tamActual);

        }

        public Alumno Busqueda(string apellido, Nodo nodo)
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
                        break;
                    }
                    actual = actual.Siguiente;
                }
            }

            return null;
        }
    }
}

