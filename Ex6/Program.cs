using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura;

            Console.WriteLine("digite seu peso");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("digite sua altura");
            altura = float.Parse(Console.ReadLine());

            float imc = peso/(altura*altura);

            if(imc < 20)
            {
                Console.WriteLine(imc + " abaixo do peso");
            }
            else
            {
                if(imc >= 20 && imc < 25)
                {
                    Console.WriteLine(imc + " peso ideal");
                }
                else
                {
                    if(imc >= 25)
                    {
                        Console.WriteLine(imc + " acima do peso");
                    }
                }
            }
        }
    }
}
