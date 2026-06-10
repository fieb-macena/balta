class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Escolha a operação: 1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão, 5 - Potenciação, 6 - Sair");

        Calcular(short.Parse(Console.ReadLine()));
    }

    static void Calcular(short operacao)
    {
        Console.WriteLine();
        switch (operacao)
        {
            case 1:
                Console.WriteLine($"O resultado da soma é: {Soma()}");
                break;
            case 2:
                Console.WriteLine($"O resultado da subtração é: {Subtracao()}");
                break;
            case 3:
                Console.WriteLine($"O resultado da multiplicação é: {Multiplicacao()}");
                break;
            case 4:
                Console.WriteLine($"O resultado da divisão é: {Divisao()}");
                break;
            case 5: 
                Console.WriteLine($"O resultado da potenciação é: {Potenciacao()}");
                break;
            case 6:
                Console.WriteLine("Saindo...");
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        Console.WriteLine();
        Menu();
    }

    static float Subtracao()
    {
        Console.WriteLine("Digite o primeiro número:");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        float numero2 = float.Parse(Console.ReadLine());
        return numero1 - numero2;
    }

    static float Soma()
    {
        Console.WriteLine("Digite o primeiro número:");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        float numero2 = float.Parse(Console.ReadLine());
        return numero1 + numero2;
    }

    static float Multiplicacao()
    {
        Console.WriteLine("Digite o primeiro número:");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        float numero2 = float.Parse(Console.ReadLine());
        return numero1 * numero2;
    }

    static float Divisao()
    {
        Console.WriteLine("Digite o primeiro número:");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        float numero2 = float.Parse(Console.ReadLine());
        return numero1 / numero2;
    }

    static float Potenciacao()
    {
        Console.WriteLine("Digite a base:");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o expoente:");
        float numero2 = float.Parse(Console.ReadLine());
        return MathF.Pow(numero1, numero2);
    }
}


