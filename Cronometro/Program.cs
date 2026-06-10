class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("Digite a opção desejada:");
        Console.WriteLine("1 - Cronômetro, 2 - Temporizador, 0 - Sair");
        string inputMenu = Console.ReadLine();

        switch (inputMenu)
        {   
            case "1":
                {
                    Console.WriteLine("Digite o tempo a ser contabilizado (mm:ss ou ss):"); 
                    Cronometro(FormataTempo(Console.ReadLine())); 
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Digite o tempo a ser contabilizado (mm:ss ou ss):"); 
                    Temporizador(FormataTempo(Console.ReadLine())); 
                    break;
                }
            case "0": { System.Environment.Exit(0); break;}
            default: { Console.WriteLine("Opção inválida, tente novamente"); Menu(); break; }
        }

    }

    static (int, int) FormataTempo(string tempo)
    {
        string[] timeParts = tempo.Split(':');
        if (timeParts.Length == 1)
            return (Convert.ToInt32(timeParts[0]), 0);
        else if (timeParts.Length == 2)
            return (Convert.ToInt32(timeParts[1]), Convert.ToInt32(timeParts[0]));
        else
            return (0, 0);
    }


    static void Cronometro((int segundos, int minutos) tempo)
    {
        int tempoTotal = (tempo.minutos * 60) + tempo.segundos;
        for (int i = 0; i <= tempoTotal; i++)
        {
            Console.Clear();
            Console.WriteLine($"Tempo: {i} segundos");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Cronômetro finalizado!");
        Menu();

    }

    static void Temporizador((int segundos, int minutos) tempo)
    {
        int tempoTotal = (tempo.minutos * 60) + tempo.segundos;
        for (int i = tempoTotal; i >= 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"Tempo restante: {i} segundos");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Temporizador finalizado!");
        Menu();
    }


}

