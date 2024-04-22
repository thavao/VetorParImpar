/*1.faça um programa que leia 10 números inteiros e imprima os seguintes itens: 

A) somente os valores pares

b) somente os valores ímpares

c) somente os valores da primeira e a ultima posição*/

int i = 0, QtdMaxiaNumeros = 10;

int[] numeros = new int[QtdMaxiaNumeros];

for (i = 0; i < QtdMaxiaNumeros; i++)
{
    Console.Write($"Digite o {i}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Os número pares digitados são:");

i = 0;
while (i < QtdMaxiaNumeros)
{
    if (numeros[i] % 2 == 0)
        Console.Write(numeros[i] + " ");

    i++;
}

Console.WriteLine();
Console.WriteLine("Os números ímapres digitados são: ");

i = 0;
do
{
    if (numeros[i] % 2 != 0)
        Console.Write(numeros[i] + " ");

    i++;
} while (i < QtdMaxiaNumeros);

Console.WriteLine();
Console.WriteLine("Pressione Enter para encerrar...");

Console.ReadLine();

