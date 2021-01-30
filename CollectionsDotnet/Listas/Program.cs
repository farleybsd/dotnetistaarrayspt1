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
