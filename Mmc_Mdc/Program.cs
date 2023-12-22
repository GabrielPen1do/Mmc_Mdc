using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmc_Mdc
{
    internal class Program
    {
        static int Mmc(int num1, int num2)
        {
            int mmc = 1;
            bool ehMMC = false;

            while (!ehMMC)
            {
                if (mmc % num1 == 0 && mmc % num2 == 0)
                {
                    ehMMC = true;
                }

                else
                {
                    mmc++;
                }
            }

            return mmc;
        }

        static int Mdc(int num1, int num2, int num3)
        {

            int div;

            if (num1 < num2 && num1 < num3)
            {
                div = num1;
            }

            else if (num2 < num1 && num2 < num3)
            {
                div = num2;
            }

            else
            {
                div = num3;
            }

            while (num1 % div != 0 || num2 % div != 0 || num3 % div != 0)
            {
                div--;
            }

            return div;


        }
        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.WriteLine("1) Calcular MMC\r\n2) Calcular MDC\r\n3) Sair do programa");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    int n1, n2, mmc;

                    Console.WriteLine("Insira o primeiro número");
                    n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o segundo número");
                    n2 = int.Parse(Console.ReadLine());

                    mmc = Mmc(n1, n2);

                    Console.WriteLine($"O mmc de {n1} e {n2} é: {mmc}");
                }

                else if (opcao == 2)
                {
                    int n1, n2, n3, mdc;

                    Console.WriteLine("Insira o primeiro número");
                    n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o segundo número");
                    n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o terceiro número");
                    n3 = int.Parse(Console.ReadLine());

                    mdc = Mdc(n1, n2, n3);

                    Console.WriteLine($"O mdc de {n1}, {n2}, {n3} é: {mdc}");
                }

                else if (opcao == 3)
                {
                    Console.WriteLine("Programa finalizado");
                }

                else
                {
                    Console.WriteLine("Insira uma opção válida");
                }



            } while (opcao != 3);

            Console.ReadKey();
        }
    }
}
