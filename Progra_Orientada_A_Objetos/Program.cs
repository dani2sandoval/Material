using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_Orientada_A_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona oPersona = new Persona("Melvin", 18, 4);
            //el new sirve para crear una instancia
            //aquí se ha creado una persona con los atributos dentro del parentesis

            //para utilizar un metodo se puede hacer lo siguiente
            oPersona.Accion();
            Console.ReadLine();

            //HERENCIA


            //Se crea un objeto que hereda los tributos de la clase carnivoro y animalleon 
            León oLeon = new León();

            oLeon.Nombre = "Simba";
            //La clase Leon no tiene como caracteristica el nombre, pero si lo tiene la clase que le da la herencia la cual es la clase animal, esa si tiene la caracteristica de nombre
            oLeon.sexo = true;
            //atributo heredado de la clase carnivoro
            oLeon.Reproduccion = "sexual";
            //atributo heredado de la clase animal
            oLeon.Peligrosidad = 10;
            //atributo heredado de la clase carnivoro

            //se puede ejecutar los dos metodos sobrecargados
            oLeon.Cazar();
            oLeon.Cazar(230);//este metodo se ira al metodo el cual si tiene parametro

            //mismo ejemplo aquí
            oLeon.Correr();
            oLeon.Correr(40, "Km");
            oLeon.Correr(16);





            Console.ReadLine();



            //Se creara un objeto que de igual forma heredara los atributos de otras clases
            Zorro oZorro = new Zorro();
            oZorro.Cazar();

            oZorro.Nombre = "sweet foxy";
            //La clase Leon no tiene como caracteristica el nombre, pero si lo tiene la clase que le da la herencia la cual es la clase animal, esa si tiene la caracteristica de nombre
            oZorro.sexo = false;
            //atributo heredado de la clase carnivoro
            oZorro.Reproduccion = "sexual";
            //atributo heredado de la clase animal
            oZorro.Peligrosidad = 4;
            //atributo heredado de la clase carnivoro

            //se puede ejecutar los dos metodos sobrecargados
            oZorro.Cazar();
            oZorro.Cazar(230);//este metodo se ira al metodo el cual si tiene parametro

            //mismo ejemplo aquí
            oZorro.Correr();
            oZorro.Correr(35, "Km");
            oZorro.Correr();



            Console.ReadLine();

            //Try

            try
            {
                //aqui se coloca el codigo que puede fallar
                //en este caso fallara porque las intrucciones indican ingresar caracteres en lugar de numeros, ya que no se pueden almacenar letras en un float
                Calculadora oCalculadora = new Calculadora();
                Console.WriteLine("Ingrese el primer nombre: ");
                float n1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el primer nombre: ");
                float n2 = float.Parse(Console.ReadLine());
            }

            //el excpetion sirve para aclarar la excepcion, en caso de recibir los parametros correctos
            catch(Exception ex)
            {
                //aqui se ejecutan acciones cuando el codigo falla
                Console.Error.WriteLine("Algo salio mal, intenta de nuevo");
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                //Siempre se una el finally, se ejecutara para
            }
            


        }


    }
}
