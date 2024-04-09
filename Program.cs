using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDevolucao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant;
            double dev = 0, valor, contV = 0;
            string resp, ope;
             
            do
            {
                Console.WriteLine("Quantidade");
                quant = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por produto: ");
                double valorP = double.Parse(Console.ReadLine());
                Console.WriteLine("Devolução[D]  Venda[V]");
                ope = Console.ReadLine();
                valor = valorP * quant;
                switch (ope)
                {
                    case "d":
                        dev += valor ;
                        break;
                    case "v":
                         contV += contV + valor; 
                        break;
                
                }
                Console.WriteLine("Deseja continuar?");
                resp = Console.ReadLine().ToLower();

            }
            while (resp == "s");
            Console.WriteLine("Valor a pagar: " + contV.ToString("C"));
            Console.WriteLine("Valor a ser devolvido: " + dev.ToString("C"));
            Console.ReadKey();
        }
    }
}
