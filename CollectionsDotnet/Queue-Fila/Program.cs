using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Fila
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            // Van
            EnfiLeirar("Van");
            //Kombi
            EnfiLeirar("Kombi");
            //Guincho
            EnfiLeirar("Guincho");
            //PickUp
            EnfiLeirar("PickUp");

            // Caro Liberado
            Desenfileirar(); // remove da fila

            // Caro Liberado
            Desenfileirar(); // remove da fila

            // Caro Liberado
            Desenfileirar(); // remove da fila

            // Caro Liberado
            Desenfileirar(); // remove da fila

            // Caro Liberado
            Desenfileirar(); // remove da fila

            Console.ReadKey();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "Guincho") // elemento que esta esperando na fila
                {
                    Console.WriteLine("Guincho está na Fila");
                }
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da Fila: {veiculo}");
                ImprimirFila();

            }
        }

        private static void EnfiLeirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo); // Adicionando na fila

            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("Fila");
            foreach (var veiculonaFila in pedagio)
            {
                Console.WriteLine(veiculonaFila);
            }
        }
    }
}
