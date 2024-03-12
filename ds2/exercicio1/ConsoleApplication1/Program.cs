using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade , dias;
            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            dias = idade * 365;
            Console.WriteLine("A sua idade em dias será de " + dias);
            Console.ReadKey();
        }
    }
}
