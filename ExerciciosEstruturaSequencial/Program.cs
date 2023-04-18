﻿using System;
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

            /* Exercício 05 - Fazer um programa para ler o código de uma peça 1, a quantidade dessa peça, o valor unitário, o código de uma peça 2, quantidade e seu valor unitário. Calcular e mostrar o valor a ser pago.

            Console.WriteLine("Digite o código da primeira peça, quantidade e o valor unitário (na mesma linha): ");
            string[] peca1 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(peca1[0]);
            int quantPeca1 = int.Parse(peca1[1]);
            double valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da segunda peça, quantidade e o valor unitário (na mesma linha): ");
            string[] peca2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(peca2[0]);
            int quantPeca2 = int.Parse(peca2[1]);
            double valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double valor1, valor2, total;

            valor1 = valorPeca1 * quantPeca1;
            valor2 = valorPeca2 * quantPeca2;

            total = valor1 + valor2;

            Console.WriteLine("Valor a pagar: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);

            */








        }
    }
}