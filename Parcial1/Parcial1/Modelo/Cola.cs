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
            if ((tamActual == 0))
            {
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            if ((tamMax > 0) && (tamMax == tamActual))
            {
                return true;
            }
            else
            {
                return false;
            }
            

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
                        break;
                    }
                    else
                    {
                        actual = actual.Siguiente;
                    }
                }
            }

            return null;
        }
    }
}

