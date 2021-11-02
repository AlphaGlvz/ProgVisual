using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuisGalvez241021
{
    /*
     * Crear un cuestionario con 10 preguntas. Cada pregunta con posibles 3 opciones. 
     * De estas 3, solo una que sea la correcta.
     * Mostrar como resultado las respuestas capturadas por el usuario y su calificación.
     * Mostrar todas las respuestas correctas.*/

    class Formulario
    {
        public int puntos;
        public int opc;


        public void SumarPuntos()
        {
            puntos = puntos + 1;
        }

        public void Preguntas()
        {
            Console.WriteLine("Escribe la respuesta correcta");
            Console.WriteLine("1.- ¿Que es el hardware?");
            Console.WriteLine("1) Es una aplicación");
            Console.WriteLine("2) Es todo lo fisico de una computadora");
            Console.WriteLine("3) Se conecta a un repetidor");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 2:
                    SumarPuntos();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("2.- ¿Cuantos lados tiene un triangulo?");
            Console.WriteLine("1) 1");
            Console.WriteLine("2) 5");
            Console.WriteLine("3) 3");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 3:
                    SumarPuntos();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("3.- ¿Cuantos lados tiene un cuadrado?");
            Console.WriteLine("1) 4");
            Console.WriteLine("2) 6");
            Console.WriteLine("3) 10");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    SumarPuntos();
                    break;
            }
            
            Console.WriteLine();
            Console.WriteLine("4.- ¿Cuanto es 1Gb convertido a Mb?");
            Console.WriteLine("1) 1000Mb");
            Console.WriteLine("2) 6Mg");
            Console.WriteLine("3) 10Mb");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    SumarPuntos();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("5.- ¿Cuanto es 15 - 5?");
            Console.WriteLine("1) 4");
            Console.WriteLine("2) 6");
            Console.WriteLine("3) 10");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 3:
                    SumarPuntos();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("6.- ¿Cuanto es 150 - 30?");
            Console.WriteLine("1) 44");
            Console.WriteLine("2) 120");
            Console.WriteLine("3) 106");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 2:
                    SumarPuntos();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("7.- ¿Que es la memoria RAM?");
            Console.WriteLine("1) Memoria de acceso aleatorio");
            Console.WriteLine("2) Memoria de almacenamiento");
            Console.WriteLine("3) Chips de integración");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    SumarPuntos();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("8.- ¿El Mouse es un periferico de salida / Mixto / Entrada?");
            Console.WriteLine("1) Salida");
            Console.WriteLine("2) Mixto");
            Console.WriteLine("3) Entrada");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 3:
                    SumarPuntos();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("9.- ¿Una Impresora es un periferico de salida / Mixto / Entrada?");
            Console.WriteLine("1) Salida");
            Console.WriteLine("2) Mixto");
            Console.WriteLine("3) Entrada");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    SumarPuntos();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("10.- ¿El Scanner es un periferico de salida/ Mixto / Entrada?");
            Console.WriteLine("1) Salida");
            Console.WriteLine("2) Mixto");
            Console.WriteLine("3) Entrada");
            Console.Write("Respuesta: ");
            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 3:
                    SumarPuntos();
                    break;
            }
        }

        public void RespuestasCorrectas()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("RESPUESTAS");
            Console.WriteLine("1.- ¿Que es el hardware?");
            Console.WriteLine("2) Es todo lo fisico de una computadora");

            Console.WriteLine("2.- ¿Cuantos lados tiene un triangulo?");
            Console.WriteLine("3) 3");

            Console.WriteLine("3.- ¿Cuantos lados tiene un cuadrado?");
            Console.WriteLine("1) 4");

            Console.WriteLine("4.- ¿Cuanto es 1Gb convertido a Mb?");
            Console.WriteLine("1) 1000Mb");

            Console.WriteLine("5.- ¿Cuanto es 15 - 5?");
            Console.WriteLine("3) 10");

            Console.WriteLine("6.- ¿Cuanto es 150 - 30?");
            Console.WriteLine("2) 120");

            Console.WriteLine("7.- ¿Que es la memoria RAM?");
            Console.WriteLine("1) Memoria de acceso aleatorio");

            Console.WriteLine("8.- ¿El Mouse es un periferico de salida / Mixto / Entrada?");
            Console.WriteLine("3) Entrada");

            Console.WriteLine("9.- ¿Una Impresora es un periferico de salida / Mixto / Entrada?");
            Console.WriteLine("1) Salida");

            Console.WriteLine("10.- ¿El Scanner es un periferico de salida/ Mixto / Entrada?");
            Console.WriteLine("3) Entrada");
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

        }

        public void ImprimirCalificación()
        {
            Console.WriteLine("Tu calificación fue de " + puntos + " puntos de 10");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Formulario form1 = new Formulario();
            form1.Preguntas();
            form1.ImprimirCalificación();
            form1.RespuestasCorrectas();
        }
    }
}
