using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuisGalvez
{

    class Persona
    {
        string nombre;
        int edad;
        string correo;

        public Persona() { }


        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetCorreo(string correo)
        {
            this.correo = correo;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public string GetCorreo()
        {
            return correo;
        }

    }

    class Animal
    {
        string nombre;
        string tipoAnimal;
        string ambiente;

        public void Duerme()
        {
            Console.WriteLine("zzzzzzzzz........");
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetTipo(string tipoAnimal)
        {
            this.tipoAnimal = tipoAnimal;
        }

        public string GetTipo()
        {
            return tipoAnimal;
        }

        public void SetAmbiente(string ambiente)
        {
            this.ambiente = ambiente;
        }

        public string GetAmbiente()
        {
            return ambiente;
        }
    }

    class Casa
    {
        int cuartos;
        int metrosCuadrados;
        string colonia;

        public Casa() { }

        public void SetCuartos(int cuartos)
        {
            this.cuartos = cuartos;
        }

        public int GetCuartos()
        {
            return cuartos;

        }

        public void SetMetrosCuadrados(int metrosCuadrados)
        {
            this.metrosCuadrados = metrosCuadrados;
        }

        public int GetMetrosCuadrados(){
            return metrosCuadrados;
        }

        public void SetColonia(string colonia)
        {
            this.colonia = colonia;
        }

        public string Getcolonia()
        {
            return colonia;
        }
    }

    class SeresVivos
    {
        public void LeerPersonas()
        {
            Persona p1 = new Persona();
            Console.Write("Escribe su nombre: ");
            p1.SetNombre(Console.ReadLine());
            Console.Write("Escribe su edad: ");
            int edad = Int32.Parse(Console.ReadLine());
            p1.SetEdad(edad);
            Console.Write("Escribe su correo: ");
            p1.SetCorreo(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Tu nombre es: " + p1.GetNombre());
            Console.WriteLine("Tu edad es: " + p1.GetEdad());
            Console.WriteLine("Tu correo es: " + p1.GetCorreo());
            Console.WriteLine("-------------------------------------");


            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public void LeerAnimal()
        {
            Animal an1 = new Animal();
            Console.Write("Escribe el nombre del animal: ");
            an1.SetNombre(Console.ReadLine());
            Console.Write("Escribe el tipo de animal: ");
            an1.SetTipo(Console.ReadLine());
            Console.Write("Escribe el ambiente del animal: ");
            an1.SetAmbiente(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("El nombre de animal es: " + an1.GetNombre());
            Console.WriteLine("El tipo es: " + an1.GetTipo());
            Console.WriteLine("El ambiente es: " + an1.GetAmbiente());
            Console.WriteLine("-------------------------------------");
            Console.Write("El "+an1.GetNombre()+" duerme ");
            an1.Duerme();

            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }

    class Construcciones
    {
        public void LeerConstrucciones()
        {
            Casa casa1 = new Casa();
            Console.Write("Cuantos cuartos tiene la casa: ");
            int cuartos = Int32.Parse(Console.ReadLine());
            casa1.SetCuartos(cuartos);
            Console.Write("Cuantos metros cuadrados tiene la casa: ");
            int mCuadrados = Int32.Parse(Console.ReadLine());
            casa1.SetMetrosCuadrados(mCuadrados);
            Console.Write("En que colonia se encuentra la casa: ");
            casa1.SetColonia(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("La casa tiene: " + casa1.GetCuartos() + " cuartos.");
            Console.WriteLine("La casa tiene: " + casa1.GetMetrosCuadrados() + " metros cuadrados");
            Console.WriteLine("La casa se encuentra en: " + casa1.Getcolonia());
            Console.WriteLine("-------------------------------------");

            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SeresVivos sv1 = new SeresVivos();
            Construcciones cns1 = new Construcciones();

            Console.WriteLine("|-------------------|");
            Console.WriteLine("| Elige una opción: |");
            Console.WriteLine("|-------------------|");
            Console.WriteLine("| 1.- Persona       |");
            Console.WriteLine("| 2.- Animal        |");
            Console.WriteLine("| 3.- Casa          |");
            Console.WriteLine("|-------------------|");
            int opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    sv1.LeerPersonas();
                    break;
                case 2:
                    sv1.LeerAnimal();
                    break;
                case 3:
                    cns1.LeerConstrucciones();
                    break;
                default:
                    Console.WriteLine("Error, opción es incorrecta");
                    Console.Write("Presiona una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
