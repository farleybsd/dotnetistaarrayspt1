using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Ligada // Linked List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de Frutas
            List<string> frutas = new List<string>
            {
                "abacate","banana","caqui","damasco","figo"
            };

            // Imprimir a lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            // Instanciando uma lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();

            // Adicionando um dia qualquer: "Quarta"
           var d4 = dias.AddFirst("Quarta");

            //Acessando o valor do nó
            Console.WriteLine("Acessando o valor do nó:" + d4.Value);

            // E para adicionar mais itens ? LinkedList nao possui add algumas formas

            // 1. Como primeiro nó
            // 2. Como ultimo nó
            // 3. Antes de um nó conhecido
            // 4. Depois de um nó conhecido

            // Vamos adicionar segunda, antes da quarta
           
            var d2 = dias.AddBefore(d4, "Segunda");  // 3. Antes de um nó conhecido

            // Agora d2 e d4 estão ligados
            // d2.next é igual a d4 pega o proximo nó
            // d4.Previous  é igual a d2 nó anterior

            // Adicionando a terça depois se segunda 
            var d3 = dias.AddAfter(d2, "Terça"); // 4. Depois de um nó conhecido

            // Adicionando a sexta depois da quarta 
            var d6 = dias.AddAfter(d4, "Sexta");

            // Adicionando Sábado depois da Sexta
           var d7= dias.AddAfter(d6, "Sábado");

            // Adicionando Quinta antes da Sexa
           var d5= dias.AddBefore(d6, "Quinta");

            // Adicionando Domingo Antes da Segunda
           var d1 =  dias.AddBefore(d2, "Domigo");

            Console.WriteLine("Imrimindo Listas Ligadas dia da semana");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            // Procurando dentro de uma lista ligada
            var quarta = dias.Find("Quarta");

            Console.WriteLine("Filtro Quarta");
            Console.WriteLine(quarta.Value);

            // Para remover um elemento
            //  Remover pelo valor quanto pela
            //   referência do LinkedListNode
            //    dias.remove("Quarta") ou dias.remove(d4)

            dias.Remove("Quarta");

            Console.WriteLine("Imrimindo sem a quarta");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.ReadKey();
            /// <image url = "$(projecDir)\Slides\Linked.png" scale="" />
        }
    }
}
