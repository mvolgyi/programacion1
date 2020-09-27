using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPnumero6.Modelo
{
    class Cola
    {
        private int tamañoMaximo = 0;
        private int tamañoActual = 0;
        private Nodo inicial;

        public Cola(int tamañomaximo = 0)
        {
            this.tamañoMaximo = tamañomaximo;
        }

        public void Enqueue(Alumno alumno)
        {
            if (!IsFull())
            {
                if (inicial == null)
                {
                    Nodo nodo = new Nodo(alumno);
                    nodo.Siguiente = inicial; 
                    inicial = nodo; 
                    tamañoActual++; 
                }
                else
                {
                    Nodo nodo = new Nodo(alumno);
                    Nodo ultimoNodo = ObtenerUltimoNodo(inicial);
                    ultimoNodo.Siguiente = nodo;
                }
                
            }
        }

        public Alumno Dequeue()
        {
            if (inicial != null)
            {
                Alumno dequueueAlumno = inicial.Alumno;
                inicial = inicial.Siguiente;
                return dequueueAlumno;
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
            return tamañoActual == 0;
        }

        public bool IsFull()
        {
            if (tamañoMaximo > 0 && tamañoMaximo == tamañoActual)
                return true;
            else
                return false;

        }

        private Nodo ObtenerUltimoNodo(Nodo nodo)
        {
            if (nodo == null || nodo.Siguiente == null) 
                return nodo;

            return ObtenerUltimoNodo(nodo.Siguiente);
        }

    }
}
