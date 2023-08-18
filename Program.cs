// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Ejercicio 5\n");

int[] a = { 4, 10, 45, -67, -7, 25, 89, 64 };

Console.WriteLine("Funcion Reverse\n");

foreach (var i in a)
    Console.WriteLine(i);

Console.WriteLine("");

System.Array.Reverse(a, 0, a.Length);
foreach (var j in a)
    Console.WriteLine(j);

Console.WriteLine("Funcion Sort\n");

foreach (var i in a)
    Console.WriteLine(i);

Console.WriteLine("");

System.Array.Sort(a, 0, a.Length);
foreach (var j in a)
    Console.WriteLine(j);