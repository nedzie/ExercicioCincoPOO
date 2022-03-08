using System;

namespace ExercicioCinco.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera bola = new Esfera();
            Console.Write("Informe o raio da esfera: \n> ");
            bola.raio = double.Parse(Console.ReadLine());

            bola.volume = bola.CalcularVolume(bola.raio);

            Console.WriteLine("O volume da esfera é de " + bola.volume.ToString("#.##") + "m³.");
        }
    }
}