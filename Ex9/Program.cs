using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Peso, Altura;
            string Sexo;

            Console.WriteLine("Peso = ");
            Peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Altura = ");
            Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Sexo(feminino ou masculino) = ");
            Sexo = Console.ReadLine();

            float imc = Peso / (Altura * Altura); 

            if (Sexo == "feminino")
            {
                if (imc < 19)
                {
                    Console.WriteLine(imc + " abaixo do peso");
                }
                else
                {
                    if (imc >= 19 && imc < 24)
                    {
                        Console.WriteLine(imc + " peso ideal");
                    }
                    else
                    {
                        Console.WriteLine(imc + " acima do peso");
                    }
                }
            }
            else
            {
                if (Sexo == "masculino")
                {
                    if (imc < 20)
                    {
                        Console.WriteLine(imc + " abaixo do peso");
                    }
                    else
                    {
                        if (imc >= 20 && imc < 25)
                        {
                            Console.WriteLine(imc + " peso ideal");
                        }
                        else
                        {
                            Console.WriteLine(imc + " acima do peso");
                        }
                    }
                }
            }

        }
    }
}
