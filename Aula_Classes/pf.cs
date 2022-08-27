using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Classes
{
    public class pf : pessoa
    {
        public string cpf;
        public string identidade;
        public string cor;
        public double altura;

        public void inserircpf()
        {
            Console.WriteLine("Digite o cpf: ");
            Console.ReadLine();
        }
        public void ident()
        {
            Console.WriteLine("Digite a identidade:");
            Console.ReadLine();
        }
        public void inscor()
        {
            Console.WriteLine("Digite a cor da pele:");
            Console.ReadLine();
        }
        public void insaltura()
        {
            Console.WriteLine("Digite a altura:");
            Console.ReadLine();
        }

    }
}
