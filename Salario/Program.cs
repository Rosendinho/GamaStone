using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Variaveis para entrar com os dados
string nome;
double salario;
double salarioHora;
double salarioDia;
double salarioSemana;
double salarioMes;
double salarioAno;

//Solicitar o nome do funcionário
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
Console.WriteLine("Qual o salário mensal?");
salario = Convert.ToInt16(Console.ReadLine());

//Calcular salário
salarioHora = salario / 220;
salarioDia = salarioHora * 8;
salarioSemana = salarioDia * 5;
salarioMes = salario;
salarioAno = salarioMes * 12;


// Mostrar menu de opcoes
Console.WriteLine(("\nEscolha uma opção da lista"));
Console.WriteLine("h - Para ganho por hora");
Console.WriteLine("d - Para ganho diário");
Console.WriteLine("s - Para ganho semanal");
Console.WriteLine("m - Para ganho mensal");
Console.WriteLine("a - Para ganho anual");

//Realizar a ação de acordo com a opção escolhida
switch (Console.ReadLine())
{
    case "h":
        Console.WriteLine($"O ganho por hora de {nome} é = R$" + Math.Round(salarioHora, 2));
        break;
    case "d":
        Console.WriteLine($"O ganho diário de {nome} é = R$" + Math.Round(salarioDia, 2));
        break;
    case "s":
        Console.WriteLine($"O ganho semanal de {nome} é = R$" + Math.Round(salarioSemana, 2));
        break;
    case "m":
        Console.WriteLine($"O ganho mensal de {nome} é = R$" + Math.Round(salarioMes, 2));
        break;
    case "a":
        Console.WriteLine($"O ganho anual de {nome} é = R$" + Math.Round(salarioAno, 2));
        break;

}
Console.Write("Pressione qq tecla para fechar o aplicativo");
Console.ReadKey();
