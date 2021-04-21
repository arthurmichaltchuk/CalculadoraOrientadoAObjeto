using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboOrientado.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora operacao1 = new Calculadora();
            double resultado;
            string opcao;
            resultado = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("...Calculadora 1.0...\n1. Para somar........\n2. Para subtrair.....\n3. Para multiplicar..\n4. Para dividir......\n5. Para ver histórico\n6. Para sair.........\n");
                opcao = Console.ReadLine();
        
                switch (opcao)
                {
                    case "1":
                        InserirNumeros(operacao1);
                        operacao1.Somar(operacao1.numero1, operacao1.numero2, out resultado); Console.WriteLine(resultado); break;
                    case "2":
                        InserirNumeros(operacao1);
                        operacao1.Subtrair(operacao1.numero1, operacao1.numero2, out resultado); Console.WriteLine(resultado); break;                 
                    case "3":
                        InserirNumeros(operacao1);
                        operacao1.Multiplicar(operacao1.numero1, operacao1.numero2, out resultado); Console.WriteLine(resultado); break;                  
                    case "4":
                        InserirNumeros(operacao1);
                        operacao1.Dividir(operacao1.numero1, operacao1.numero2, out resultado); Console.WriteLine(resultado); break;
                    case "5":operacao1.Visualizar();break;
                    case "6":break;
                    default:Console.WriteLine("Opção inválida! Tente novamente");break; 
                }
                Console.ReadLine();
            } while (opcao != "6");         
        }

        private static void InserirNumeros(Calculadora operacao1)
        {
            Console.WriteLine("Digite o primeiro número: ");
            operacao1.numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            operacao1.numero2 = Convert.ToDouble(Console.ReadLine());
        }
    } 
}
