//CALCULADORA INICIAL
Menu();


static void Menu()
{
    Console.Clear();

    Console.WriteLine("INICIALIZANDO PROGRAMA");
    Console.WriteLine("");

    Console.WriteLine("Qual operação deseja realizar? ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("------------");
    Console.WriteLine("Selecione uma opção: ");
    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }

}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor:");
    float v2 = float.Parse(Console.ReadLine());


    Console.WriteLine("");

    float resultado = v1 + v2;
    Console.WriteLine($"A soma dos valores é {resultado} ");
    Console.ReadKey();
    Finalizar();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado dessa subtração é {resultado}");
    Console.ReadKey();
    Finalizar();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 * v2;
    Console.WriteLine($"O resultado dessa multiplicação é {resultado}");
    Console.ReadKey();
    Finalizar();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 / v2;
    Console.WriteLine($"O resutado dessa divisão é {resultado}");
    Console.ReadKey();
    Finalizar();
}

static void Finalizar()
{
    Console.Clear();
    Console.WriteLine("Deseja realizar outra operação?");
    Console.WriteLine("1 -  SIM");
    Console.WriteLine("2 - NÂO");

    Console.WriteLine("---------");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Menu(); break;
        case 2: System.Environment.Exit(0); break;
        default: Finalizar(); break;
    }

}