using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresValore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3;

            Console.WriteLine("digite o primeiro valor");
            N1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo valor");
            N2 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro valor");
            N3 = float.Parse(Console.ReadLine());

            if(N1 == N2 && N2 == N3)
            {
                Console.WriteLine("os valores são iguais");
            }
            else
            {
                if (N1 == N2 && N2 > N3)
                {
                    Console.WriteLine("o primeiro e o segundo valor são maiores");
                }
                else
                {
                    if(N1 == N3 && N1 > N2)
                    {
                        Console.WriteLine("o primeiro e o terceiro valor são maiores");
                    }
                    else
                    {
                        if( N2 == N3 && N2 > N1)
                        {
                            Console.WriteLine("o segundo e o terceiro valor são maiores");
                        }
                        else
                        {
                            if(N1 > N3 && N1 > N2)
                            {
                                Console.WriteLine("o primeiro valor é maior");
                            }
                            else
                            {
                                if(N2> N3 && N2 > N1)
                                {
                                    Console.WriteLine("o segundo valor é maior");
                                }
                                else
                                {
                                    if(N3 > N2 && N3 > N1)
                                    {
                                        Console.WriteLine("o terceiro valor é maior");
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
