using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swithteste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t---Calcula aumento salarial---\n");
            Console.WriteLine("\nCargos: \n\t[1] Gerente\n\t[2] Engenheiro\n\t[3] Tecnico");
            Console.Write("\nInforme o cargo: ");
            int cargo=int.Parse(Console.ReadLine());
           
            Console.WriteLine("Informe seu salario atual ");
            double salario=double.Parse(Console.ReadLine());

            double novosalario = 0;

            switch (cargo)
            {
                case 1:
                    novosalario = salario + (salario * 0.1);
                    break;
                    case 2:
                    novosalario = salario + (salario * 0.2);
                    break;
                case 3:
                    novosalario = novosalario + (salario * 0.3);
                    break;
                default:
                    novosalario = novosalario + (salario * 0.4);
                    break;


            }
            Console.WriteLine($"\nSalario antigo: {salario.ToString("")}");

        }
        }
    }

