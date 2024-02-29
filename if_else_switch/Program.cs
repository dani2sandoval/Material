using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace if_else_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SENTENCIA IF
            //Consiste en una expresion booleana seguida de una o mas sentencias

            bool bandera = true;


            if (!bandera) //si la varaiable bandera es falsa nos imprime "variable verdadera"
            {
                Console.WriteLine("Variable verdadera");

            }


            //SENTENCIA IF ELSE
            //Puede ser distinguida por una sentencia else, que se ejecuta cuando la expresion booleana es falsa

            //SENTENCIA IF ANIDADO
            //También es posible usar una sentencia if o else dentro de otro if o if else

            int a = 6, b = 3, c = 9;

            if (a > b)  //Si se cumple que a es mayor, pasa al siguiente if
            {
                if (a > c) // si se cumple esa condicion va a imprimir que a es mayor
                {
                    Console.WriteLine("A es mayor");
                }
                else  // de lo contrario imprime que c es mayor
                {
                    Console.WriteLine("C es mayor");

                }
            }
            else // si la condicion del principio (a>b) no se cumple entonces viene al else y compara b con c
            {
                if (b > c) //si b es mayor que c se imprime b es mayor
                {
                    Console.WriteLine("B es mayor");
                } else
                {
                    Console.WriteLine("C es mayor"); //de lo contrario se imprime c es mayor
                }
            }

            Console.ReadLine();


            //SENTENCIA SWITCH
            //Una sentencia switch permite a una variable ser probada por una lista de condiciones. Cada condicion se llama case

            int opción = 0; // así es para trabajar con numeros, pero se puede usar string si se quiere usar letras

            string opcion = "a";

            switch (opción)
            {
                case 1:
                    Console.WriteLine("Opcion 1");
                    break;

                case 2:
                    Console.WriteLine("Opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Opcion 3");
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            Console.ReadLine();


            //Práctica
            void verificar_edad()
            {
                Console.WriteLine("Menu");
                Console.WriteLine("a. Saludar");
                Console.WriteLine("b. Sumar");
                Console.WriteLine("Escriba su opcion: ");
                string numero = Console.ReadLine();

                switch (numero)
                {
                    case "a":
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Hola " + nombre);
                        break;

                    case "b":
                        Console.WriteLine("Ingrese el primer número: ");
                        int numero1 = Console.Read();
                        Console.WriteLine("Ingrese segundo numero: ");
                        int numero2 = Console.Read();
                        Console.WriteLine("La suma es: " + numero1 + numero2);
                        break;

                    default:
                        Console.WriteLine("Agrega una opcion correcta");
                        break;


                }



            }

            //Operador Ternario

            
            
            int Temperatura = Console.Read();
            string estado_de_agua;

            if (Temperatura < 0)
            {
                estado_de_agua = "solido";
            }
            else
            {
                estado_de_agua = "liquido";
            }

            Console.WriteLine("El estado del agua es " + estado_de_agua);

            Temperatura += 30;

            estado_de_agua = Temperatura < 0 ? "solido" : "liquido";

            Temperatura -= 150;

            estado_de_agua = Temperatura > 99 ? "gaseoso" : Temperatura < 0 ? "solido" : "liquido";

            Console.WriteLine("El estado del agua es " + estado_de_agua);

            Console.ReadLine();


        }




    }
}
