using System.Xml.Serialization;

Console.Clear();
Console.WriteLine("Digite um número: ");
float v1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
float v2 = float.Parse(Console.ReadLine());

Console.WriteLine(""); //Pra pular linha

float soma = v1 + v2;
Console.WriteLine("O resultado é: " + soma);