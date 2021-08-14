using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_C
{
    class Estudiantes
    {
        static void Main(string[] args)
        {
            //definir el arreglo estudiantes con 10 elementos
            string[] estudiantes = new string[5];
            string[] genero = new string[5];
            int[] edad = new int[5];

            //almacenara la cantidad de estudiantes con el genero femenino
            int femenino = 0; //inicializamos la variable
            //almecenara la cantidad de estudiantes con el genero masculino
            int masculino = 0; //inicializamos la variable
            //almacenara todas las edades de arreglo EDAD
            int suma = 0; //inicializamos la variable
            //almacenara el promedio
            int promedio = 0;

            //solicitar nombres
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write("Escriba el nombre para el alumno {0}: ", i+1);
                estudiantes[i] = Console.ReadLine();
                Console.Write("Seleccione el genero f/m: ");
                genero[i] = Console.ReadLine();
                Console.Write("Digite la edad del estudiante:");
                edad[i] = Convert.ToInt32(Console.ReadLine());
            }


            // suma de valores para encontrar el promedio de edades
            for (int i = 0; i < edad.Length; i++)
            {
                suma += edad[i];
            }

            promedio = suma / 5;
            //imprimir datos de los estudiantes
            //ordenar array
            Console.WriteLine("DATOS DE LOS ESTUDIANTES");
            //  Array.Sort(estudiantes); //ORDENA EL ARRAY
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Nombre: {0} | Genero: {1}", estudiantes[i], genero[i]);

                //evaluar la cantidad de estudiantes con el genero femeniino
                if (genero[i] == "f")
                {
                    //femenino = femenino + 1;
                    femenino += 1;
                }
                if (genero[i] == "m")
                {
                   
                    masculino += 1;
                }
            }
            Console.WriteLine("La cantidad de estudiantes con genero femenino es {0}", femenino);
            Console.WriteLine("La cantidad de estudiantes con genero masculino es {0}", masculino);
            Console.WriteLine("El promedio de las edades de todos los estudiantes es {0}", promedio);
            Console.ReadKey();
        }
    }
}
