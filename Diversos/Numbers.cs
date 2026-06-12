using System.Globalization;

namespace Diversos;

class Numbers
{
    public static void Show()
    {

        Console.Clear();



        var valor = 10.25;
        var culture = CultureInfo.GetCultureInfo("pt-BR");

        //formatador numérico
        Console.WriteLine(valor.ToString("G", culture));
        Console.WriteLine(valor.ToString("F", culture)); //mais precisão
        Console.WriteLine(valor.ToString("N", culture));
        Console.WriteLine(valor.ToString("P", culture)); //porcentagem


        //formatador moeda
        Console.WriteLine(valor.ToString("C", culture));

        Console.WriteLine(valor.ToString("E02", culture));


        //Math
        Console.WriteLine(Math.Sqrt(valor));
        Console.WriteLine(Math.Round(valor));
        Console.WriteLine(Math.Ceiling(valor));
        Console.WriteLine(Math.Floor(valor));
    }
}



