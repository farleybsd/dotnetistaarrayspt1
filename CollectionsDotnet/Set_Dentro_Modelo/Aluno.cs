using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Dentro_Modelo
{
    class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {nome},Matrícula: {numeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (obj == null) return false;

            return this.nome.Equals(outro.nome);
        }

        /*
         *  Dois objetos são iguais possuem o mesmo hashcode
         *  Porem, o contrário não é verdadeiro
         *  Dois objetos com  mesmo hash codes não são necessáriamente iguais
         */
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}
