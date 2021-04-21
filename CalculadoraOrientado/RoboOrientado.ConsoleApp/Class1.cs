using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboOrientado.ConsoleApp
{
    public class Calculadora
    {
        string operador;
        int cont;
        string[] hist = new string[100];
        public double numero1;
        public double numero2;
        internal void Somar(double numero1, double numero2, out double resultado)
        {
            resultado = numero1 + numero2; 
            operador = "+";
            Registrador(operador, resultado);
        }
        internal void Subtrair(double numero1, double numero2, out double resultado)
        {
            resultado = numero1 - numero2;
            operador = "-";
            Registrador(operador, resultado);
        }
        internal void Multiplicar(double numero1, double numero2, out double resultado)
        {
            resultado = numero1 * numero2;
            operador = "*";
            Registrador(operador, resultado);
        }
        internal void Dividir(double numero1, double numero2, out double resultado)
        {
            resultado = numero1 / numero2;
            operador = "/";
            if (numero2 != 0)
                Registrador(operador, resultado);
            else
                Console.Write("ERR");resultado = 0;
        }
        public void Registrador(string op, double resultado)
        {
            hist[cont] = $"{numero1} {op} {numero2} = {resultado}";
            cont++;
        }
        public void Visualizar()
        {
            if (hist[0] == null)
            {
                Console.WriteLine("Histórico vazio...");
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    if (hist[i] != null)
                    {
                        Console.WriteLine(hist[i]);
                    }
                }
            }      
        }
    }
}
