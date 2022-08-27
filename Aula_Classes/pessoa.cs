using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Classes
{
    public class pessoa
    {
        public string nome;
        public int idade;

        public void inserirnome(string nome) 
        {
            Console.WriteLine(" O nome é: \n" + nome);
        }
        public void inseriridade() 
        {
            Console.WriteLine("A idade é: ");
            Console.ReadLine(); 
        }
        
    }
}
