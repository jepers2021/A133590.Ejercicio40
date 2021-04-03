using System;

namespace A133590.Ejercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 40");
            Console.WriteLine("Programa que recibe una frase e imprime cada palabra de la frase separada por línea.");
            Console.Write("Por favor, ingrese una frase: ");
            string frase = Console.ReadLine();
            foreach(string palabra in frase.Split())
            {
                Console.WriteLine(palabra);
            }
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
