using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace while_dowhile_for
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //WHILE
            //While es una estructura de control que permite repetir un determinado numero de veces una tarea.

            int numero = 1;

            while (5 >= numero) //mientras esa sea la condicion nunca se va a cumplir porque 1 es igual a 1

            {
                Console.WriteLine("Hola ");
                numero++; //la variable numero se va a ir incrementando, y cuando llegue a cinco se terminara el bucle de imprimir

            }

            Console.ReadLine();


            int limite = 10, numero_2 = 1;

            while (numero_2 <= limite) //se evalua la condicion, mientras numero2 sea menor o igual que limite
            {
                if (numero_2 % 2 == 0) //comparara el residuo del numero dividido con 0
                {
                    Console.WriteLine(numero_2 + " es par"); //si es 0 se imprimirá que es par
                } else if (numero_2 % 2 == 1)
                {
                    Console.WriteLine(numero_2 + " es impar"); //si el residuo es 1 se imprime que es impar
                }
                else
                {
                    Console.WriteLine(numero_2 + " otro numero");
                }
                numero_2++; // cuando termina un proceso el numero se aumenta hasta llegar a 11, cuyo numero ya no es valido para seguir trabajando el bucle

            }

            Console.ReadLine();


            //DO WHILE

            int valor = 5;

            do
            {
                Console.WriteLine("Hola, el numero es " + valor); //se imprime eso
                valor++; //se va incrementando el valor de la variable

            } while (valor < 10); // y se repite lo anterior hasta que la condicion dentro del while no sea valida




            Console.ReadLine();


            //FOR

            int tabla = 4, limit = 10;
            //
            for (int multiplicador = 1; multiplicador <= limit; multiplicador++) //

            //se declara una variable con valor 1, mientras esa variable sea menor o igual al limite, se realiza la accion, hasta que la variable creada ya no este cumpliendo con la condicion para hacer la accion

            {
                Console.WriteLine(tabla + " * " + multiplicador + " = " + tabla * multiplicador);
            }

            Console.ReadLine();






            



        }
    }
}
