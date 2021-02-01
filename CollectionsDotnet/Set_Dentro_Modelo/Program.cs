using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Dentro_Modelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vamos declarar o curso
            Curso csharpColecoes = new Curso("C# Colecoes","Marcelo Oliveira");

            // Adcicionando 3 aulas a esse curso
            csharpColecoes.Adicona(new Aula("Trabalhando com Listas",21));
            csharpColecoes.Adicona(new Aula("Criando uma Aula",20));
            csharpColecoes.Adicona(new Aula("Modelando Coleções",24));

            // Criar Aluno com nome e numero de matricula

            Aluno a1 = new Aluno("Vanessa Tonini",34672);
            Aluno a2 = new Aluno("Ana Losnak",5617);
            Aluno a3 = new Aluno("Rafael Nercessian",17645);

            // Matricular o Aluno no Curso
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            // Imprimindo os alunos matriculados
            Console.WriteLine("Imprimindo os alunos matriculados");

            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            // o aluno está matriculado

            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado {csharpColecoes.EstaMatriculado(a1)}");

            // matricular Aluno

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine($"Tonini está  matriculada ? {csharpColecoes.EstaMatriculado(tonini)}");

            Console.WriteLine("a1 == a Tonini");
            Console.WriteLine(a1 == tonini);

            Console.WriteLine("a1 == a Tonini");
            Console.WriteLine(a1.Equals(tonini));

            // São diferentes! Precisamos então implementar Equals()
            Console.WriteLine("a1 == a Tonini");
            Console.WriteLine(a1.Equals(tonini));

            Console.WriteLine($"Nome : {a1.Nome} , HahCode : {a1.GetHashCode()}");


            Console.ReadKey();

        }
    }
}
