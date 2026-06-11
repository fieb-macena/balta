using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace EditorHTML;

public class Viewer
{
    public static void View(string texto)
    {
        Console.Clear();
        Console.WriteLine("Modo de visualização (pressione qualquer tecla para continuar)");
        Console.WriteLine("=====================");
        Console.WriteLine("");
        var formatedText = Replace(texto);
        Console.WriteLine(formatedText);
        Console.ReadKey();
    }

    public static string Replace(string text)
    {
        //var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var words = text.Split(" ");
        var formatedText = new StringBuilder();
        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].Contains("<strong>") || words[i].Contains("</strong>"))
            {
                //Console.BackgroundColor = ConsoleColor.Blue;
                formatedText.Append(
                    words[i].Substring(
                        words[i].IndexOf('>') + 1,
                        words[i].LastIndexOf('<')
                    )
                );
                formatedText.Append(" ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                formatedText.Append(words[i] + " ");
            }
        }
        return formatedText.ToString();

    }

    public static void Read()
    {
        Console.Clear();
        Console.WriteLine("Informe o caminho do arquivo a ser lido:");
        var caminho = Console.ReadLine();
        using (var arquivo = new StreamReader(caminho))
        {
            string texto = arquivo.ReadToEnd();
            View(texto);
        }
    }
}