Console.Clear();

static void Soma()
{
    Console.WriteLine("Bem-vindo ao método de Soma");
    Console.ReadKey();
    Console.WriteLine("Digite um número: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite outro número: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine(""); //Pra pular linha

    float soma = v1 + v2;
    Console.WriteLine("O resultado é: " + soma);
    Console.ReadKey();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao Método de Subtração");
    Console.ReadKey();

    Console.WriteLine("Digite o primeiro número: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("O resultado é: " + (v1 - v2));
    Console.ReadKey();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao Método de Divisão");
    Console.ReadKey();

    Console.WriteLine("Digite o primeiro número: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("O resultado é: " + (v1 / v2));
    Console.ReadKey();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Bem Vindo ao Método de Multiplicação");
    Console.ReadKey();
    Console.WriteLine("Digite o primeiro número: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("O resultado é:  " + (v1 * v2));
    Console.ReadKey();
}
