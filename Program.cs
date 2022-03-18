Console.Clear();
Menu();

static void Menu()
{
    const short SOMA = 1;
    const short SUBTRACAO = 2;
    const short DIVISAO = 3;
    const short MULTIPLICACAO = 4;
    const short SAIR = 5;

    Console.Clear();
    Console.WriteLine("Bem Vindo a Calculadora DV!");
    Console.ReadKey();
    Console.WriteLine("--------------------");
    Console.WriteLine("Escolha uma opção!");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("--------------------");
    Console.WriteLine("Selecione uma opção: ");

    short res = short.Parse(Console.ReadLine());
    switch (res)
    {
        case SOMA:
            Soma();
            break;
        case SUBTRACAO:
            Subtracao();
            break;
        case DIVISAO:
            Divisao();
            break;
        case MULTIPLICACAO:
            Multiplicacao();
            break;
        case SAIR:
            Environment.Exit(0);
            break;
        default:
            Menu();
            break;
    }
}

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
    Menu();
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
    Menu();
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
    Menu();
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
    Menu();
}
