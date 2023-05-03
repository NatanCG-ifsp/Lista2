using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float L1, L2;

            Console.WriteLine("digite o valor do primeiro lado");
            L1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor do segundo lado");
            L2 = float.Parse(Console.ReadLine());

            float Area = L1 * L2;
            
            Console.WriteLine("A area mede " + Area + " metros quadrados");
            
            if(Area > 100)
            {
                Console.WriteLine("TERRENO GRANDE!");
            }
        }
    }
}
