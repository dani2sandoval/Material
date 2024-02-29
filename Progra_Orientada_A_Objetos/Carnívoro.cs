using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_Orientada_A_Objetos
{
    public class Carnívoro : Animal
        //Carnivoro esta heredando la caracteristicas de la clase animal, en este caso el nombre ya que es la unica nombrada

    {
        public int Peligrosidad { get; set; }

        public bool sexo { get; set; }

        private int promedio = 3;

        //metodo sin parametros
        public void Cazar()
        {
            Console.WriteLine("El carnivoro casa al rededor de " + promedio + "animales");
        }



        //sobrecarga significa tener múltiples métodos dentro de una clase los cuales contienen el mismo nombre
        //el metodo Cazar ya existe, pero al tener mas con ese mismo nombre se denomina sobrecaga


        //este metodo recibe un parametro de una variable
        public void Cazar(int presas)
        {
            Console.WriteLine("presas posibles: " + presas);
        }

        //este metodo no tiene parametro
        public void Correr()
        {
            Console.WriteLine("El animal esta corriendo");
        }

        //este metodo tiene el mismo nombre que el anterior pero tiene dos parametros
        public void Correr (int velocidad, string medida)
        {
            Console.WriteLine("Corriendo a " + velocidad + " " + medida + " por hora");
        }

        //este metodo tiene un parametro de tipo short, si tuviera otro metodo con un parametro tendria que ser de diferente tipo de variable
        public void Correr (short hora)
        {
            Console.WriteLine("Hora de mayor actividad: " + hora);

        }


    }
}
