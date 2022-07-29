using System;
using System.Collections.Generic;

namespace SequenciaFibonati
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de valores");
            ulong ValorFinal = Convert.ToUInt32(Console.ReadLine());
            ulong i;
            List<Valores> Valores = new List<Valores>() { new Valores { a = 0, b = 1, c = 0 } };
            List<ulong> Resultado = new List<ulong>();
            Console.WriteLine("Resultado");
            for (i = 0; i < ValorFinal; i++)
            {
                foreach (var item in Valores)
                {
                    item.c = item.a + item.b;
                    item.a = item.b;
                    item.b = item.c;
                    Resultado.Add(item.a);
                    Console.WriteLine((i + 1) + "º Valor: " + item.a);
                }
            }
            Console.WriteLine("Você quer algum valor especifico? ");
            string ResultValorEspecifico = Console.ReadLine().ToLower();
            if (ResultValorEspecifico == "Sim".ToLower())
            {
                Console.WriteLine("Qual posição você deseja? ");
                var PosicaoEspecifica = Convert.ToInt32(Console.ReadLine());
                ulong sim = Resultado[PosicaoEspecifica - 1];
                Console.WriteLine("Resultado");
                Console.WriteLine(sim);
            }
            Console.ReadKey();
        }

        //Testando polices 

        public class Valores
        {
            public ulong a { get; set; }
            public ulong b { get; set; }
            public ulong c { get; set; }
        }
    }
}
