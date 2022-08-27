using System;

namespace Aula_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            pessoa pessoa = new pessoa();
            pf pf = new pf();
            pj pj = new pj();
            string nome = pessoa.nome;
            int idade = pessoa.idade;
            Console.WriteLine("Digite o nome: " + nome);
            Console.ReadLine();
            //Console.WriteLine("Digite a idade: " + idade);
            //Console.ReadLine();
            pessoa.inseriridade();
            pf.inserircpf();
            pf.insaltura();
            pj.inserirrazaosocial();
            Console.ReadKey();
        }
    }
}
