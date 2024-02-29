using System; //estas son librerias adicionales que se necesitan para ejecutarse
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1 //este namespace es el nombre de nuestra aplicacion, o el entorno en el que se desarrolla nuestra app
{ //llave necesaria para el contenido de la aplicacion
    public class Program  //se declara una clase llamada program, se pueden agregar diferentes niveles: como el public, private, pero en este caso es public
    {
        static void Main(string[] args) //indica que es un metodo de tipo estático, que no esta regresando un resultado numerico o letra, solo un proceso
        //el nombre del metodo se llama main, este metodo nos ayuda a ejecutar o comenzar nuestro programa.
        //el string significa que el metodo main recibirá un arreglo de tipo string con el nombre de args,

        {// en estas llaves se contiene nuestro método
            Console.WriteLine("Hola Mundo, esto es C#"); //esta es la forma de impresion
            //Console.Read(); //comando para leer, pero esperara a que nosotros introduzcamos un dato por teclado
            Console.WriteLine("5 * 7 =" + (5*7)); //para concatenar se usa el signo de suma
            Console.WriteLine("Fin");
            Console.Read();
            

        }
    }
}
