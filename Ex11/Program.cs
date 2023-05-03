using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float P1, P2;

            Console.WriteLine("nota da primeira prova");
            P1 = float.Parse(Console.ReadLine());

            P2 = (15 - P1) / 2;

            Console.WriteLine($" o aluno precisa tirar {P2} na segunda prova");
        }
    }
}
