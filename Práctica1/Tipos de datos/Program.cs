using System; //estas son librerias adicionales que se necesitan para ejecutarse
using System; //se usa using para indicar que se quiere usar un espacio de nombre system
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_datos //nosotros mismos creamos este namespace, si deseamos usar este mismo name space podemos importarlo en otro proyecto con using Tipos_de_datos
{
    public class Program
    {
        static void Main(string[] args)

        {



            int numero = 2000; //esta es una variable de tipo entero (int)
            byte numero_2 = 255; // se muestra en rojo porque el valor que se le atribuyó es mayor a 255
            float pi = 3.141593298743290F; //se debe agregar la F para convertir el dato de tipo double a float
            double doble = 3.141593298743290;
            decimal dinero = 150.50M; //se debe agregar la M para que haga la conversión a decimal 
            char letra = 'M'; //solo se le puede agregar un caracter a la variable de tipo char
            bool bandera = true; //solo puede ser verdadero o falso
            String cadena = "Hola"; //variable que almacena caracteres

            Console.WriteLine(numero); //se indica la impresion de la variable llamada numero
            Console.WriteLine(numero_2);
            Console.WriteLine(pi);
            Console.WriteLine(doble);
            Console.WriteLine(dinero);
            Console.WriteLine(letra);
            Console.WriteLine(bandera);
            Console.WriteLine(cadena);
            Console.WriteLine();

            


            Console.WriteLine("Concatenación: " + cadena + " " + numero); //Para realizar una concatenación se van agregando elementos con el signo mas
            

            //OPERADORES ARIMETICOS

            //SUMA
            Console.WriteLine(numero + numero_2);

            //RESTA
            Console.WriteLine(numero - numero_2);

            //MULTIPLICACION
            Console.WriteLine(numero * numero_2);

            //DIVISION
            Console.WriteLine(numero / numero_2);

            //RESTO DE DIVISION
            Console.WriteLine(numero % numero_2);
            Console.WriteLine();



                    //OPERADORES DE ASIGNACION

                    //SUMA
                    Console.WriteLine(numero += numero_2);

                    //RESTA
                    Console.WriteLine(numero -= numero_2);

                    //MULTIPLICACION
                    Console.WriteLine(numero *= numero_2);

                    //DIVISION
                    Console.WriteLine(numero /= numero_2);

                    //RESTO DE DIVISION
                    Console.WriteLine(numero % numero_2);

            

            //OPERADORES DE ASIGNACION

            //IGUAL QUE             ==      A == B
            //DIFERENTE QUE         !=      A != B
            //MENOR QUE             <       A < B
            //MAYOR QUE             >       A > B
            //MENOR O IGUAL QUE     <=      A <= B
            //MAYOR O IGUAL QUE     =>      A => B

                    

                    //OPERADORES LOGICOS

                    //AND (Y)  &&
                    //OR  (O)  ||
                    //NOT (No) !
            
                    

            //OPERADORES DE INCREMENTO

            //Incremento    ++
            //Decremento    --


        }
    }
}
