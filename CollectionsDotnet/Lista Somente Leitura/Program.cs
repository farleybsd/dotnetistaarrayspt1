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

            // Adicionando Duas Aulas

            csharpCollection.Adicona(new Aula("Criando uma Aula",20));
            csharpCollection.Adicona(new Aula("Modelando com Coleçoes",19));

            // Imprimir
            Imprimir(csharpCollection.Aulas);

            // Ordernar a lista de aulas 
            // copiar uma lista somente leitura para uma outra lista
            List<Aula> aulascopiadas = new List<Aula>(csharpCollection.Aulas);
            // Ordernar a copia
            aulascopiadas.Sort();

            Imprimir(aulascopiadas);

            // totalizar o tempo do curso

            Console.WriteLine("Tempo de aulas do curso é :" + csharpCollection.TempoTotal);

            Console.WriteLine("Dados Do Curso");
            Console.WriteLine(csharpCollection);

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
