using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaStone
{    
    internal class Salario
    {
        string nome;
        double salario;

        public void Entrada()
        {
            Console.WriteLine("Nome do funcionário: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário :");
            salario = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qual salário deseja verificar: h, d, s, m, a ");

            switch (Console.ReadLine())
            {
                case ("h"):
                    calSalarioHora(salario);
                    break;
                case ("d"):
                    calSalarioDia(salario);
                    break;
                case ("s"):
                    calSalarioSemana(salario);
                    break;
                case ("m"):
                    calSalarioMes(salario);
                    break;
                case ("a"):
                    calSalarioAno(salario);
                    break;
            }

        }

        private void calSalarioAno(double salario)
        {
            Console.WriteLine($"O salário de {nome} é " + Math.Round(salario * 12, 2) + " por ano.");
            Console.ReadLine();
        }

        private void calSalarioMes(double salario)
        {
            Console.WriteLine($"O salário de {nome} é " + Math.Round(salario, 2) + " por mês.");
            Console.ReadLine();
        }

        private void calSalarioSemana(double salario)
        {
            Console.WriteLine($"O salário de {nome} é " + Math.Round((salario / 220) * 40, 2) + " por semana.");
            Console.ReadLine();
        }

        private void calSalarioDia(double salario)
        {
            Console.WriteLine($"O salário de {nome} é " + Math.Round((salario / 220) * 8, 2) + " por dia.");
            Console.ReadLine();
        }

        private void calSalarioHora(double salario)
        {
            Console.WriteLine($"O salário de {nome} é " + Math.Round(salario / 220, 2) + " por hora.");
            Console.ReadLine();
        }

        public double CalcSalario(double ISalario, char tipo)
        {
            switch (tipo)
            {
                case ('h'):
                    Console.WriteLine($"O salário de {nome} é " + ISalario / 220 + " por hora.");
                    break;
                case ('d'):
                    Console.WriteLine($"O salário de {nome} é " + (ISalario / 220) * 8 + " por dia.");
                    break;
                case ('s'):
                    Console.WriteLine($"O salário de {nome} é " + (ISalario / 220) * 40 + " por semana.");
                    break;
                case ('m'):
                    Console.WriteLine($"O salário de {nome} é " + ISalario + " por mês.");
                    break;
                case ('a'):
                    Console.WriteLine($"O salário de {nome} é " + ISalario * 12 + " por ano.");
                    break;
            }

            return ISalario;


        }
    }
}