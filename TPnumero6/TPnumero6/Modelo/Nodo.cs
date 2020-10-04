using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPnumero6.Modelo
{
    public class Nodo
    {
        /// <summary>
        /// En esta clase creamos el nodo del tipo alumno
        /// </summary>
        public Alumno Alumno { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Alumno alumno) //Es el constructor que recibe un objeto de tipo alumno y se lo setea al nodo.
        {
            
            this.Alumno = alumno;   // Inicializa el objeto alumno
        }
    }
}
