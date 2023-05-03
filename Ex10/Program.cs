using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float P1, P2, M;

            Console.WriteLine("nota da primeira prova =");
            P1 = float.Parse(Console.ReadLine());
            Console.WriteLine("nota da segunda prova");
            P2 = float.Parse(Console.ReadLine());

            M = (P1 + 2*P2)/3;

            if (M >= 5) Console.WriteLine("APROVADO");
            else Console.WriteLine("reprovado"); 
        }
    }
}
