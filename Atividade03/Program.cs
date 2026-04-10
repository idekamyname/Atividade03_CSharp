using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"Título: {Titulo} | Autor: {Autor}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro[] livros = new Livro[4];

            livros[0] = new Livro { Titulo = "O Alquimista", Autor = "Paulo Coelho" };
            livros[1] = new Livro { Titulo = "Dom Casmurro", Autor = "Machado de Assis" };
            livros[2] = new Livro { Titulo = "1984", Autor = "George Orwell" };
            livros[3] = new Livro { Titulo = "O Hobbit", Autor = "J.R.R. Tolkien" };

            Console.WriteLine("---Lista de Livros---");
            foreach (Livro l in livros)
            {
                l.Exibir();
            }
        }
    }
}
