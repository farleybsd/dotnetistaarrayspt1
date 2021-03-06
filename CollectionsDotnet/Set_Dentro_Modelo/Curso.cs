﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Dentro_Modelo
{

    class Curso
    {

        // Alunos deve ser um Iset.Alunos deve retornar ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }
        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }

        }

        internal void Adicona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;

                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}

                //return total;

                // LINQ = LANGUAGE Integrated Query
                // Consulta Integrada á Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"[Curso: {nome}, Tempo: {TempoTotal}, Aulas:{string.Join(",", aulas)}]";
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.NumeroMatricula == numeroMatricula)
                    return aluno;
            }
            throw new Exception("Matricula não Encontrada" + numeroMatricula);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

    }
}

