using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        
        

        static void Main(string[] args)
        {
            int cont = 0;
            double sl = 0;
            while (cont == 0)
            {
                Console.WriteLine("Qual a forma de contratação do funcionário?");
                Console.WriteLine("Digite 1 para assalariado");
                Console.WriteLine("Digite 2 para comissionado");
                Console.WriteLine("Digite 3 para horista");
                Console.WriteLine(" ");
                int contratacao = int.Parse(Console.ReadLine());


                switch (contratacao)
                {
                    case 1:
                        Console.WriteLine("Informe o valor do seu salário bruto: ");
                        double sb = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o desconto: ");
                        double desc = double.Parse(Console.ReadLine());

                        sl = sb - desc;
                        Console.WriteLine("O salário liquido é de: " + sl);
                        cont = 1;
                        break;

                    case 2:
                        Console.WriteLine("Informe a quantidade de peças vendidas: ");
                        double qp = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor da comissão por peça vendida: ");
                        double vc = double.Parse(Console.ReadLine());

                        sl = qp * vc;
                        cont = 1;
                        Console.WriteLine("O salário será de: " + sl);
                        break;

                    case 3:
                        Console.WriteLine("Informe o valor por hora: ");
                        double vh = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                        double qh = double.Parse(Console.ReadLine());

                        sl = qh * vh;
                        Console.WriteLine("O salário é de: " + sl);
                        cont = 1;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                if (sl >= 2000)
                {
                    double desc = sl * 0.075;
                    double ir = sl - desc;
                    Console.WriteLine("O seu salário, com desconto do IR, será de: " + ir);
                }
                else if (sl == 4000)
                {
                    double desc = sl * 0.12;
                    double ir = sl - desc;
                    Console.WriteLine("O seu salário, com desconto do IR, será de: " + ir);
                }
                else if(sl > 4000)
                {
                    double desc = sl * 0.15;
                    double ir = sl - desc;
                    Console.WriteLine("O seu salário, com desconto do IR, será de: " + ir);

                }

                       
            }

            Console.ReadKey();

        }
    }
}
