using System;
using System.Globalization;

namespace ExerciciosEstruturaSequencial {
    public class Program {
        public static void Main(string[] args) {

            /* Exercício 01 - Soma de valores inteiros: 
             * 
             * 
            Console.WriteLine("Entre dois números inteiros para soma: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int soma = x + y;

            Console.WriteLine("SOMA: " + soma);
            
             */

            /* Exercício 02 - O programa deve ler o valor do raio de um círculo e calcular o valor da área deste círculo com 4 casas decimais
            Considerando fórmula da área = area = pi * raio² e o valor de pi = 3.14159


            Console.WriteLine("Entre com o valor do raio de um círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Valor da área: " + area.ToString("F4"), CultureInfo.InvariantCulture);

            */

            /* Exercício 03 - Fazer um programa para ler quatro valores inteiros (A,B,C e D). A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segunda a fórmula: DIFERENCA = (A * B - C * D).

            Console.WriteLine("Digite quatro valores inteiros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            Console.WriteLine();

            Console.WriteLine("DIFERENÇA = " + diferenca);

            */

            /* Exercício 04 - Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.


            Console.WriteLine("Digite o número do funcionário: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o valor da hora desse funcionário? ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorHora;

            Console.WriteLine();

            Console.WriteLine("Número do funcionário: " + numeroFuncionario);
            Console.WriteLine("Salário: R$" + salario.ToString("F2"), CultureInfo.InvariantCulture);

            */










        }
    }
}