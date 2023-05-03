using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A, B, C;

            Console.WriteLine("primeiro valor");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine("terceiro valor");
            C = float.Parse(Console.ReadLine());

            if((A * A) == (B * B) + (C * C) ||(B * B) == (A * A) + (C * C) ||(C * C) == (A * A) + (B * B))
            {
                Console.WriteLine("é um Triângulo retângulo");
            }
            else
            {
                Console.WriteLine("não é um Triângulo retângulo");
            }
        }
    }
}
