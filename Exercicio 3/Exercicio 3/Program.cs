using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gold = new List<double>();
            List<double> montarias = new List<double>();

            int input = -1;

            Console.WriteLine("Digite um número negativo quando desejar parar.");
            Console.WriteLine("Digite a quantidade de gold, dê enter, e digite a quantidade de montarias:");

            while (input != 0)
            {
                input = Convert.ToInt32(Console.ReadLine());

                if (input > 0)
                    gold.Add(input);
                else if (input < 0)
                {
                    Console.WriteLine("Por ser um número negativo, deu erro");
                    break;
                }

                input = Convert.ToInt32(Console.ReadLine());

                if (input > 0)
                    montarias.Add(input);
                else if (input < 0)
                {
                    Console.WriteLine("Por ser um número negativo, deu erro");
                    break;
                }
            }
            Console.WriteLine("O número abaixo é a média de gold dos jogadores:");
            Console.WriteLine(gold.Average());

            Console.WriteLine("O número abaixo é a média de montarias dos jogadores:");
            Console.WriteLine(montarias.Average());

            Console.WriteLine("O número abaixo é a quantidade maior de gold que um jogador possui:");
            gold.Sort();
            Console.WriteLine(gold.Last());

            Console.WriteLine("Este é o percentual de jogadores com até 100 gold:");
            Console.WriteLine(((double)gold.FindAll(x => x <= 100).Count / (double)gold.Count) * 100 + "%");

            Console.ReadKey();
        }
    }
}
