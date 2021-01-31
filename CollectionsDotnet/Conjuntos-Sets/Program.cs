using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Sets= Conjuntos
             *  Não permite duplicidade
             *  os elementos não são mantidos em orem específica
             *  Mais rapido que a lista
             *  Desempenho HashSet x List
             */

            // Declando o conjunto de Alunos
            ISet<string> alunos = new HashSet<string>();
            // Adicionando Alunos : Vanessa,Ana,Rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            // Imprimindo
            Console.WriteLine(string.Join(",",alunos));

            // Adicionando : priscila , rollo , fabio
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            // Imprimindo
            Console.WriteLine(string.Join(",", alunos));

            // removendo ana, adicionando o marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            // Imprimindo
            Console.WriteLine(string.Join(",", alunos));

            // ordernando por Sort
            List<string> alunoEmLista = new List<string>(alunos);
            alunoEmLista.Sort();
            // Imprimindo
            Console.WriteLine(string.Join(",",alunoEmLista));


            Console.ReadKey();
        }
    }
}
