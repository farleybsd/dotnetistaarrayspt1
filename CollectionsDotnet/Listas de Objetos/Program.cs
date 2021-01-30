using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução a coleção",20);
            var aulaModelando = new Aula("Modelando a Classe Alura",18);
            var aulaSets = new Aula("Trabalhando com conjutos",16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            imprimir(aulas);

            aulas.Sort();

            imprimir(aulas);

            aulas.Sort((esteobj, outroobj) => esteobj.Tempo.CompareTo(outroobj.Tempo));

            imprimir(aulas);

            Console.ReadKey();
        }

        private static void imprimir(List<Aula> aulas)
        {
            Console.Clear();

            aulas.ForEach(aula => Console.WriteLine(aula));
        }
    }

    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }

        public override string ToString()
        {
            return $"[título:{titulo} , tempo: {tempo} minutos]";
        }
    }
}
