using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04_Foreach_Média_de_Notas_em_uma_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> lista = new List<double>();

            lista.Add(10.0);
            lista.Add(20.0);
            lista.Add(30.0);

            double media = 0.0;

            foreach (double valor in lista)
            {
                media += valor;
            }

            media /= lista.Count;

            Console.WriteLine("A média dos valores na lista é: {0}", media);

            Console.WriteLine("Digite 2 para sair");

            Console.ReadKey();
        }
    }
}
        

