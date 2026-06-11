using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

public static class Editor
{
    public static void Display()
    {   
        Console.Clear();
    }

    public static void Start()
    {
        Console.Clear();
        
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        
        Console.Clear();
        Console.WriteLine("Deseja salvar o arquivo? (S/N)");
        var salvar = Console.ReadLine().ToUpper();
        if(salvar == "S")
            Write();

    }

    public static void Read()
    {
        
    }

    public static void Write()
    {
        
    }
}