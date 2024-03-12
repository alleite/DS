using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3 , med, p1, p2, p3;
            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            p1 = n1 * 2;
            p2 = n2 * 3;
            p3 = n3 * 5; 
            med = p1 + p2 + p3 / 10;

            Console.WriteLine("A média final será " + med);
            Console.ReadKey();
        }
    }
}
