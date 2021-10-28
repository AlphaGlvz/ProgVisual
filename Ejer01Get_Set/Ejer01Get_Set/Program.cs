using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejer01Get_Set
{

    class Persona{
        string nombre;
        int edad;

        //Constructor
        public Persona(){}

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetEdad()
        {
            return edad;
        }
    }

    class Program{

        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.SetNombre("Luis Angel");
            p1.SetEdad(24);

            Console.WriteLine("Tu nombre es: " +p1.GetNombre());
            Console.WriteLine("Tu edad es: " + p1.GetEdad());
            Console.ReadLine();//Presionar Enter
        }
    }
}
