using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using EditorHTML;

public static class Editor
{

    public static void Write()
    {
        Console.Clear();

        var file = new StringBuilder();

        Console.WriteLine("EDITOR HTML \n =============================");

        string line;
        do
        {
            line = Console.ReadLine();
            file.Append(line);
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Viewer.View(file.ToString());

        Console.WriteLine("Deseja salvar o arquivo? (S/N)");
        var salvar = Console.ReadLine().ToUpper();
        if (salvar == "S")
            Salvar(file);

        Menu.Show();
    }

    public static void Salvar(StringBuilder text)
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
}