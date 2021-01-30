using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Somente_Leitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpCollection = new Curso("c#Collections","Marcelo Oliveira");
            csharpCollection.Adicona(new Aula("Trabalhando com listas",21));
            Imprimir(csharpCollection.Aulas);

            Console.ReadKey();
        }
        
        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
