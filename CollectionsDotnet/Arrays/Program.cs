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

            Console.WriteLine("A aula modelando está no indice - " + Array.IndexOf(aulas,AulaModelando));

            Console.WriteLine("o ultimmo indice e " + Array.LastIndexOf(aulas, AulaModelando));

            Console.WriteLine("Revertendo a ordem de um array ");
            Array.Reverse(aulas);
            Imprimir(aulas);

            Console.WriteLine("Diminuido o tamanho de um array");
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Console.WriteLine("Aumentanto o tamanho de um array");
            Array.Resize(ref aulas, 3);
            aulas[aulas.Length - 1] = "conclusao";
            Imprimir(aulas);

            Console.WriteLine("Ordem Alfabetica");
            Array.Sort(aulas);
            Imprimir(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Console.WriteLine("Imprimindo Copia de Array ");
            Imprimir(copia);

            Console.WriteLine("Imprimindo um clone");

            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            Console.WriteLine("Limpado um array");
            Array.Clear(clone,1,2);
            Imprimir(clone);
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
