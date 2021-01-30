using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as coleções";
            string AulaModelando = "Modelando a classe Aula";
            string aulaSets = "Trabalhando com conjuntos";

            string[] aulas = new string[]
            {
                aulaIntro,
                AulaModelando,
                aulaSets
            };

            string[] aulasDois = new string[3];
            aulasDois[0] = aulaIntro;
            aulasDois[1] = AulaModelando;
            aulasDois[2] = aulaSets;

            Imprimir(aulas);

            Console.ReadKey();
        }

        private static void Imprimir(string[] aulas)
        {
            foreach (var item in aulas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
