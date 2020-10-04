using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPnumero6.Modelo
{
    public class Cola
    {
        private int tamañoMaximo = 0; // Defini variable privada para que solo el programador pueda tener acceso a ella.
        private int tamañoActual = 0;
        private Nodo inicial;   //Cree una variable incial de nodo y otra final
        private Nodo final;

        public Cola(int tamañomaximo = 0)   // Inicializo la cola CONSTRUCTOR
        {
            inicial = null;
            final = null;
            this.tamañoMaximo = tamañomaximo;

        }
       

        public void Enqueue(Alumno alumno) //Recibe un tipo de dato: Alumno
        {
            Nodo nodo = new Nodo(alumno);       //Creo un nodo de tipo nodo y le paso el alumno que va a recibir
            if (inicial == null)
            {
                inicial = nodo;
                inicial.Siguiente = null;
                final = nodo;
                tamañoActual++; //contador
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
                tamañoActual--; // Vamos dejando espacio en la cola al sacarle nodos
                return dequeueAlumno;                
            }
            return null;
        }

        public Alumno Peek()    // Se ve que hay en el primer item. Solo lectura.
        {
            if (inicial != null)
            {
                Alumno peekAlumno = inicial.Alumno;
                return peekAlumno;
            }
            return null;
        }

        public bool IsEmpty()   //Cheuqea si esta vacia la cola
        {
            if (tamañoActual == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsFull()    //Chequea si esta llena la cola
        {
            if (tamañoMaximo > 0 && tamañoMaximo == tamañoActual)
                return true;
            else
                return false;

        }
    }
}
