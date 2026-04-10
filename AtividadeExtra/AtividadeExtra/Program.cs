using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeExtra
{
    // 1.
    public class Filme
    {
        public string Titulo;
        public int Ano;

        public void Exibir() => Console.WriteLine($"Filme: {Titulo} ({Ano})");
    }

    // 2.
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    // 3.
    public class Produto
    {
        public string Nome;
        public double Preco;

        public double PrecoComDesconto(double percentual)
        {
            return Preco - (Preco * (percentual / 100));
        }
    }

    // 4.
    public class Aluno
    {
        public string nome;
        public double nota;

        public bool Aprovado() => nota >= 6.0;
    }

    // 5.
    public class Funcionario
    {
        public string nome;
        public string cargo;
        public double salario;

        public void Exibir()
        {
            Console.WriteLine("Funcionário: " + nome + " | Cargo: " + cargo + " | Salário: R$ " + salario);
        }

        ~Funcionario()
        {
            Console.WriteLine("Tchau!, " + nome + ", Vejo você no próximo dia");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Filme[] filmes = new Filme[3];
            filmes[0] = new Filme { Titulo = "Matrix", Ano = 1999 };
            filmes[1] = new Filme { Titulo = "Inception", Ano = 2010 };
            filmes[2] = new Filme { Titulo = "Interstellar", Ano = 2014 };

            for (int i = 0; i < filmes.Length; i++)
            {
                filmes[i].Exibir();
            }

            // 2.
            Pessoa[] pessoas = {
            new Pessoa("Maria", 20),
            new Pessoa("Ana", 25),
            new Pessoa("Carlos", 30),
            new Pessoa("Bia", 22)
            };

            foreach (var p in pessoas)
            {
                Console.WriteLine($"{p.Nome} tem {p.Idade} anos.");
            }

            // 3.
            Produto[] produtos = new Produto[3];
            produtos[0] = new Produto { Nome = "Mouse", Preco = 100.0 };
            produtos[1] = new Produto { Nome = "Teclado", Preco = 200.0 };
            produtos[2] = new Produto { Nome = "Monitor", Preco = 800.0 };

            foreach (var prod in produtos)
            {
                Console.WriteLine($"{prod.Nome}: R$ {prod.PrecoComDesconto(10):F2} (com 10% OFF)");
            }

            // 4.
            Aluno[] listaAlunos = new Aluno[5];

            listaAlunos[0] = new Aluno { nome = "Carlos", nota = 8.5 };
            listaAlunos[1] = new Aluno { nome = "Maria", nota = 5.0 };
            listaAlunos[2] = new Aluno { nome = "José", nota = 7.2 };
            listaAlunos[3] = new Aluno { nome = "Ana", nota = 4.5 };
            listaAlunos[4] = new Aluno { nome = "Lucas", nota = 6.0 };

            Console.WriteLine("--- Resultado Final ---");

            foreach (Aluno aluno in listaAlunos)
            {
                if (aluno.Aprovado())
                {
                    Console.WriteLine("O aluno " + aluno.nome + " está APROVADO com nota " + aluno.nota);
                }
                else
                {
                    Console.WriteLine("O aluno " + aluno.nome + " está REPROVADO com nota " + aluno.nota);
                }
            }

            //5.
            Funcionario[] equipe = new Funcionario[3];
            equipe[0] = new Funcionario { nome = "Carlos", cargo = "Gerente", salario = 5000.00 };
            equipe[1] = new Funcionario { nome = "Beatriz", cargo = "Desenvolvedora", salario = 4500.00 };
            equipe[2] = new Funcionario { nome = "Ricardo", cargo = "Designer", salario = 3800.00 };

            Console.WriteLine("--- Listagem de Funcionários ---");

            foreach (Funcionario f in equipe)
            {
                f.Exibir();
            }

            Console.WriteLine("\nFim da listagem. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
