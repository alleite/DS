using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, brancos, nulos, validos;
            double x, y, z;

            Console.WriteLine("Digite a quantidade total de eleitores: ");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade total de votos em branco: ");
            brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade total de votos nulos: ");
            nulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade total de votos validos: ");
            validos = int.Parse(Console.ReadLine());

            x = (brancos * total) / 100;
            y = (nulos * total) / 100;
            z = (validos * total) / 100;

            Console.WriteLine("O número de votos em branco em relação ao total será de " + x + ", o número de votos nulos em relação ao total será de " + y +
" e o números de votos válidos será de " + z);
            Console.ReadKey();
        }
    }
}
