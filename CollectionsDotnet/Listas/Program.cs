using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução ás Coleções";
            string aulaModelando = "Modelado a classe Aula";
            string AulaSet = "Trabalhando com  Conjuntos";

            List<string> aulas = new List<string>
            {
                aulaIntro,
                aulaModelando,
                AulaSet
            };

            imprimir(aulas);

            List<string> aulasdois = new List<string>();

            aulasdois.Add(aulaIntro);
            aulasdois.Add(aulaModelando);
            aulasdois.Add(AulaSet);

            imprimir(aulasdois);

            Console.WriteLine("A primeira aula é " + aulasdois[0]);
            Console.WriteLine(" Exemplo dois - A primeira aula é " + aulasdois.First());

            Console.WriteLine("A ultima aula é " + aulasdois[aulasdois.Count - 1]);
            Console.WriteLine(" Exemplo Dois - A ultima aula é " + aulasdois.Last());

            aulasdois[0] = "Trabalhando com Listas";
            imprimir(aulasdois);

            Console.WriteLine("A primeira aula 'Trabalhando' é :"
                + aulasdois.Last(aula =>  aula.Contains("Trabalhando")));


            Console.WriteLine("A ultima aula 'Trabalhando' é :"
                + aulasdois.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A primeira aula 'Conclusão' é :"
                + aulasdois.FirstOrDefault(aula => aula.Contains("Conclusão")));

            Console.WriteLine("Invertendo a ordem ");
            aulasdois.Reverse();
            imprimir(aulasdois);

            Console.WriteLine("Remvendo um indice");
            aulasdois.RemoveAt(aulas.Count - 1);
            imprimir(aulasdois);

            aulasdois.Add("Conclusao");
            imprimir(aulasdois);

            Console.WriteLine("Ordem Alfabetica");
            aulasdois.Sort();
            imprimir(aulasdois);


            Console.WriteLine("Fazendo uma copia dos dois ultimos registros");

            List<string> copia = aulasdois.GetRange(aulasdois.Count -2 ,2);
            imprimir(copia);

            Console.WriteLine("Fazendo um clone");
            List<string> clone = new List<string>(aulasdois);
            imprimir(clone);

            Console.WriteLine("removendo dos dois ultimos itens");
            clone.RemoveRange(clone.Count - 2,2);
            imprimir(clone);
            Console.ReadKey();

        }

        private static void imprimir(List<string> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });
        }
    }
}
