using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();

            Console.ReadKey();
        }
    }

    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();

        private readonly Stack<string> historicoProximo = new Stack<string>();

        private string atual = "vazia";
        public Navegador()
        {
            Console.WriteLine("Pagina Atual: " + atual);
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);//adicionando um elemento da pilha
                atual = historicoAnterior.Pop();
                Console.WriteLine("Pagina Atual: " + atual);
            }

        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Pagina Atual: " + atual);
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop(); // remove um elemento da pilha
                Console.WriteLine("Pagina Atual: " + atual);

            }
        }
    }
}
