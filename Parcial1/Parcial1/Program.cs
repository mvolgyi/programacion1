using Parcial1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamCola = 0;
            string opcion;

            Console.Write("Ingrese el tamaño deseado para la cola:  ");
            tamCola = Convert.ToInt32(Console.ReadLine());

            Cola cola = new Cola(tamCola);

            //Menu
            Console.WriteLine("Ingrese una opcion, para salir utilise la opcion 'X': ");
            Console.WriteLine("A para agregar alumnos a la cola.");
            Console.WriteLine("B para borrar alumnos de la cola.");
            Console.WriteLine("P para ver el primer alumnos de la cola.");
            Console.WriteLine("V para consultar si la cola esta vacia.");
            Console.WriteLine("L para consultar si la cola esta llena.");
            Console.WriteLine("S para buscar alumno por apellido.");
            Console.WriteLine("X para salir.");
            opcion = Console.ReadLine();

            while (opcion != "X")
            {
                switch (opcion)
                {
                    case "A":
                        if (cola.IsFull() == false)
                        {
                            Alumno alumno = new Alumno();

                            Console.WriteLine("Ingreso de datos de Alumnos: ");
                            Console.WriteLine("Nombre: ");
                            alumno.Nombre = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Apellido: ");
                            alumno.Apellido = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Fecha de nacimiento: ");
                            alumno.FechaDeNac = Convert.ToDateTime(Console.ReadLine());

                            cola.Enqueue(alumno);
                            Console.WriteLine(" ");
                            Console.WriteLine("El alumno ingresado es {0} {1} con fecha de nac. {2}", alumno.Nombre, alumno.Apellido, alumno.FechaDeNac);
                        }
                        else
                        {
                            Console.WriteLine("Cola llena");
                        }
                        
                        break;

                    case "B":
                        if (cola.IsEmpty() == false)
                        {
                            Alumno alumnoBorrado = cola.Dequeue();
                            Console.WriteLine(" ");
                            Console.WriteLine("El alumno {0} ah sido eliminado", alumnoBorrado.Nombre + " " + alumnoBorrado.Apellido);
                        }
                        else
                        {
                            Console.WriteLine("No hay nada que borrar, cola vacia.");
                        }

                        break;

                    case "P":
                        if (cola.IsEmpty() == false)
                        {
                            if ((cola.Peek().Nombre != null) && (cola.Peek().Nombre != null))
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("El primer alumno de la cola es: {0}", cola.Peek().Nombre + " " + cola.Peek().Apellido);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay nada para ver.");
                        }

                        break;

                    case "V":
                        if (cola.IsEmpty() == true)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("La cola esta vacia");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("La cola contiene datos");
                        }
                        break;

                    case "L":
                        if (cola.IsFull() == true)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("La cola esta llena");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Todavia hay espacio en la cola");
                        }
                        break;

                    case "S":
                        if (cola.IsEmpty() != true)
                        {
                            Console.WriteLine(" ");

                            string apellidoAlumno;
                            Alumno alumno;
                            Console.WriteLine("Ingrese el apellido del alumno que se desee buscar");
                            apellidoAlumno = Console.ReadLine();
                            alumno = cola.Busqueda(apellidoAlumno);
                            if (alumno != null)
                            {
                                Console.WriteLine("Se econtro al alumno: {0} {1} {2}", alumno.Nombre, alumno.Apellido, alumno.FechaDeNac);
                            }
                            else
                            {
                                Console.WriteLine("Alumno no encontrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Todavia hay espacio en la cola");
                        }
                        break;

                    default:
                        Console.WriteLine("Por favor seleccione una opcion correcta.");
                        break;
                }

                //Menu
                Console.WriteLine("Ingrese una opcion, para salir utilise la opcion 'X': ");
                Console.WriteLine("A para agregar alumnos a la cola.");
                Console.WriteLine("B para borrar alumnos de la cola.");
                Console.WriteLine("P para ver el primer alumnos de la cola.");
                Console.WriteLine("V para consultar si la cola esta vacia.");
                Console.WriteLine("L para consultar si la cola esta llena.");
                Console.WriteLine("S para buscar alumno por apellido.");
                Console.WriteLine("X para salir.");
                opcion = Console.ReadLine();
                Console.WriteLine("  ");
            }

        }

    }
}
