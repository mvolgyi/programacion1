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
            int tamañoCola = 0;
            int opcionMenu;

            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|Ingrese el tamaño deseado para la cola:  |");
            Console.WriteLine("|-----------------------------------------|");
            tamañoCola = Convert.ToInt32(Console.ReadLine());

            Cola cola = new Cola(tamañoCola);

            /*-Menu*/
            Console.WriteLine("|----------Menu de seleccion---------------|");
            Console.WriteLine("|1: Agregar Alumno | 4: Esta vacia la cola?|");
            Console.WriteLine("|2: Borrar Alumno  | 5: Esta llena la cola?|");
            Console.WriteLine("|3: Ver 1° en cola | 6: Buscar por apellido|");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("|---------Precione 0 para salir------------|");
            Console.WriteLine("|------------------------------------------|");
            opcionMenu = Convert.ToInt32(Console.ReadLine());
            /*Menu-*/
            while (opcionMenu != 0)
            {
                switch (opcionMenu)
                {
                    case 1:
                        if (cola.IsFull() == false)
                        {
                            Alumno alumno = new Alumno();

                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|Nombre del alumno:            |");
                            Console.WriteLine("|------------------------------|");
                            alumno.Nombre = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|Apellido del alumno:          |");
                            Console.WriteLine("|------------------------------|");
                            alumno.Apellido = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("|----------------------------------|");
                            Console.WriteLine("|Fecha de nacimiento del alumno:   |");
                            Console.WriteLine("|----------------------------------|");
                            alumno.FechaDeNac = Convert.ToDateTime(Console.ReadLine());

                            cola.Enqueue(alumno);
                            Console.WriteLine("|----------------------------------------------------|");
                            Console.WriteLine("|   Alumno {0} {1} nacido el {2} ingreso a la cola   |", alumno.Nombre, alumno.Apellido, alumno.FechaDeNac);
                            Console.WriteLine("|----------------------------------------------------|");
                        }
                        else
                        {
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|Cola llena, no hay mas espacio|");
                            Console.WriteLine("|------------------------------|");
                        }
                        
                        break;

                    case 2:
                        if (cola.IsEmpty() == false)
                        {
                            Alumno alumnoBorrado = cola.Dequeue();
                            Console.WriteLine("|-------------------------------|");
                            Console.WriteLine("|El alumno {0} {1} fue eliminado|", alumnoBorrado.Nombre, alumnoBorrado.Apellido);
                            Console.WriteLine("|-------------------------------|");
                        }
                        else
                        {
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|           Cola vacia         |");
                            Console.WriteLine("|------------------------------|");
                        }

                        break;

                    case 3:
                        if (cola.IsEmpty() == false)
                        {
                            if ((cola.Peek().Nombre != null) && (cola.Peek().Nombre != null))
                            {
                                Console.WriteLine("|---------------------------------------|");
                                Console.WriteLine("|El primer alumno de la cola es: {0} {1}|", cola.Peek().Nombre, cola.Peek().Apellido);
                                Console.WriteLine("|---------------------------------------|");
                            }
                        }
                        else
                        {
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|    No hay nadie en la cola   |");
                            Console.WriteLine("|------------------------------|");
                        }

                        break;

                    case 4:
                        if (cola.IsEmpty() == true)
                        {
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|         Cola vacia           |");
                            Console.WriteLine("|------------------------------|");
                        }
                        else
                        {
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|    Hay alumnos en la cola    |");
                            Console.WriteLine("|------------------------------|");
                        }
                        break;

                    case 5:
                        if (cola.IsFull() == true)
                        {
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|Actualemten la cola esta llena|");
                            Console.WriteLine("|------------------------------|");
                        }
                        else
                        {
                            Console.WriteLine("|--------------------------------|");
                            Console.WriteLine("|La cola no esta llena actuamente|");
                            Console.WriteLine("|--------------------------------|");
                        }
                        break;

                    case 6:
                        if (cola.IsEmpty() != true)
                        {
                            Console.WriteLine("|------------------------------|");

                            string apellidoAlumno;
                            Alumno alumno;
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|  Ingrese apellido a buscar   |");
                            Console.WriteLine("|------------------------------|");
                            apellidoAlumno = Console.ReadLine();
                            alumno = cola.Busqueda(apellidoAlumno);
                            if (alumno != null)
                            {
                                Console.WriteLine("|---------------------------------|");
                                Console.WriteLine("|Se econtro al alumno: {0} {1} {2}|", alumno.Nombre, alumno.Apellido, alumno.FechaDeNac.ToString("dd/mm/yyyy"));
                                Console.WriteLine("|---------------------------------|");
                            }
                            else
                            {
                                Console.WriteLine("|------------------------------------|");
                                Console.WriteLine("|El alumno no se encuentra en la cola|");
                                Console.WriteLine("|------------------------------------|");
                            }
                        }
                        else
                        {
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|Todavia hay espacio en la cola|");
                            Console.WriteLine("|------------------------------|");
                        }
                        break;

                    default:
                        Console.WriteLine("|----------------------------------------|");
                        Console.WriteLine("|    Seleccione una opcion correcta      |");
                        Console.WriteLine("|----------------------------------------|");
                        break;
                }

                /*-Menu*/
                Console.WriteLine("|----------Menu de seleccion---------------|");
                Console.WriteLine("|1: Agregar Alumno | 4: Esta vacia la cola?|");
                Console.WriteLine("|2: Borrar Alumno  | 5: Esta llena la cola?|");
                Console.WriteLine("|3: Ver 1° en cola | 6: Buscar por apellido|");
                Console.WriteLine("|------------------------------------------|");
                Console.WriteLine("|---------Precione 0 para salir------------|");
                Console.WriteLine("|------------------------------------------|");
                opcionMenu = Convert.ToInt32(Console.ReadLine());
                /*Menu-*/
            }

        }

    }
}
