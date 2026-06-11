using System;
using System.Text;

Menu();

static void Menu()
{
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Abrir arquivo, 2 - Novo Arquivo, 0 - Sair");
    string inputMenu = Console.ReadLine();
    switch (inputMenu)
    {
        case "1": { Abrir(); break; }
        case "2": { NovoArquivo(); break; }
        case "0": { System.Environment.Exit(0); break; }
        default: { Console.WriteLine("Opção inválida, tente novamente"); Menu(); break; }
    }
}

static void NovoArquivo()
{
    Console.WriteLine("Edite o texto: (Pressione ESC para sair)");
    var texto = new StringBuilder();

    do
    {
        texto.Append(Console.ReadLine());
        texto.Append(Environment.NewLine);
    }while(Console.ReadKey().Key != ConsoleKey.Escape);

    Console.WriteLine("Deseja salvar o arquivo? (S/N)");
    if(Console.ReadLine().ToUpper() == "S")
        Salvar(texto);
    else
        System.Environment.Exit(0);

}

static void Salvar(StringBuilder text)
{
    Console.Clear();
    Console.WriteLine("Digite o caminho do arquivo a ser salvo:");
    string caminho = Console.ReadLine();

    using (var arquivo = new StreamWriter(caminho))
    {
        arquivo.Write(text);
    }

    Console.WriteLine(string.Format("Arquivo salvo com sucesso em {0}", caminho));
}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Digite o caminho do arquivo a ser editado:");
    string caminho = Console.ReadLine();

    using (var arquivo = new StreamReader(caminho))
    {
        string texto = arquivo.ReadToEnd();
        Console.WriteLine(texto);
    }
}
