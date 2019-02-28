using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();

            Console.WriteLine("Lanzando Dados...");

            Dados D1 = new Dados(R.Next(1,6), "Blanco");
            Dados D2 = new Dados(R.Next(1,6), "Negro");
            Dados D3 = new Dados(R.Next(1,6), "Rojo");

            Console.WriteLine("Resultados:");
            D1.Imprimir();
            D2.Imprimir();
            D3.Imprimir();

            
            Console.ReadKey();
        }
    }
}