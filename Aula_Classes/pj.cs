using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Classes
{
    public class pj : pessoa
    {
        public string razaoSocial;
        public string cnpj;
        public string endereco;
        public int qtdFuncionarios;

        public void inserirrazaosocial()
        {
            Console.WriteLine("Digite a razão social: ");
            Console.ReadLine();
        }
        public void inserircnpj()
        {
            Console.WriteLine("Digite o cnpj: ");
            Console.ReadLine();
        }
        public void inserirendereco()
        {
            Console.WriteLine("Digite o endereço: ");
            Console.ReadLine();
        }
        public void inserirqtdfunc()
        {
            Console.WriteLine("Digite a quantidade de funcionários: ");
            Console.ReadLine();
        }

    }
}
