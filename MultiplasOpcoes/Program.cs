﻿int num1;
int num2;
int opcao;
double resultado = 0;

Console.Write("Digite um número:");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número:");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite uma opção abaixo:");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multiplicar");
Console.WriteLine("4 - Dividir");
opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 1:
        resultado = num1 + num2;
        break;

    case 2:
        resultado = num1 - num2;
        break;

    case 3:
        resultado = num1 * num2;
        break;

    case 4:
        resultado = num1 / num2;
        break;
    default:
        Console.WriteLine("Opção Invalida");
        break;
}

Console.WriteLine("Resultado" + resultado);
