using System;

namespace Progra_Orientada_A_Objetos
{

    public class Persona
    //public es una palabra reservada

    {
        // Los objetos en programación son una forma de representar cosas o conceptos en el contexto de un programa.
        //Por Ejemplo un carro, el cual puede tener muchas cosas adentro, o es constituido por dentro
        //Las clases son los modelos sobre los cuáles se construirán nuestros objetos, mientras que los objetos son instancias de esa clase. 
        //En el Ejemplo la clase puede ser "carro" y tener atributos como, motor, puertas, llantas etc

        public string Nombres { get; set; }
        //las clases tienen atributos, y esta es la forma de definir un atributo
        //los atributos son las caracteristicas de las clases

        public int Edad { get; set; }
        //esta es otra clase

        public int Habilidades { get; set; }

        public Persona(string Nombres, int Edad, int Habilidades) //Estos seran los atributos que se enviaran al objeto
            //esste es un contructor y sirve para enviar datos a un programa


        {
            //para diferenciar los atributos anteriormente creados con los atributos de este contructor nos servira el this
            this.Nombres=Nombres;
            this.Edad=Edad;
            this.Habilidades = Habilidades;

        }


        public void Accion()
        //metodo son las acciones que puede hacer una caracteristica
        //el valor void indica que la clase no va a retornar un valor de salida, no es necesario meterle parametros

            {
            for (int i = 0; i < Habilidades; i++) ;

            Console.WriteLine("Habilidad desarrollada");

            }

        //metodos estático 
        //no es necesario instanciarlo para llamarlo
        public void Caminar()
        {
            Console.WriteLine($"{Nombres} esta caminando");

        }

        



        

    }
}