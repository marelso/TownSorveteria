using System;
using System.Linq;

namespace PesquisaSorveteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a sequencia de numeros:\n");
            var console = Console.ReadLine();

            if (string.IsNullOrEmpty(console))
                return;

            var array = console.Split(',');
            Pesquisa(array);
            Console.ReadLine();
        }
        static void Pesquisa(string[] array)
        {
            var itens = new int[5];
            for (int item = 0; item < itens.Length; item++)
            {
                if (array.Contains(item.ToString()))
                    itens[item] += array.Count(numero => numero == item.ToString());
            }

            var quantidade = itens.Max();
            var id = itens.ToList().IndexOf(quantidade);
            if (quantidade == 0)
            {
                Console.WriteLine("Não foi possível contabilizar, informe somente os códigos participantes.");
            }
            else
            {
                switch (id)
                {
                    case 0:
                        Console.WriteLine($"O mais popular é o sorvete de Flocos com {quantidade} de votos!");
                        break;
                    case 1:
                        Console.WriteLine($"O mais popular é o sorvete de Chocolate com {quantidade} de votos!");
                        break;
                    case 2:
                        Console.WriteLine($"O mais popular é o sorvete de Morango com {quantidade} de votos!");
                        break;
                    case 3:
                        Console.WriteLine($"O mais popular é o sorvete de Creme com {quantidade} de votos!");
                        break;
                    case 4:
                        Console.WriteLine($"O mais popular é o sorvete de Napolitano com {quantidade} de votos!");
                        break;
                    default:
                        Console.WriteLine("Não foi possivel contabilizar o mais popular.");
                        break;
                }
            }
        }
    }
}
