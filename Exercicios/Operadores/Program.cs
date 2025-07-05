// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Atribuindo um variável

int a = 10;
int b = 20;

int c = a + b;

//c = c + 5;

c += 5; // outra forma de representar a soma de c = c + 5

Console.WriteLine(c);

c -= 5;

Console.WriteLine(c);

c *= 5;

Console.WriteLine(c);

// cast - casting Convertendo uma variável
a = Convert.ToInt32("5");

Console.WriteLine(a);

b = int.Parse("10"); // usando o método Parse para efetuar a conversão

Console.WriteLine(b);

// Diferença do método Convert para Parse será a questão de tratar o valor vazio

a = Convert.ToInt32(null);
Console.WriteLine(a);
// Aceita o valor nulo, já o método Parse o valor não pode ser nulo


//Tratando conversão para string

int inteiro = 5;
string d = inteiro.ToString();

Console.WriteLine(d);


double k = 4 / 2 + 2;
Console.WriteLine(k);

/*
int a = 10;
int b = 20;

int c = a + b;

Console.WriteLine(c);*/
