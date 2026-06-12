using System.Data.Common;
using System.Security.AccessControl;

namespace Diversos;

class Arrays
{
    public static void Show()
    {
        var array1 = Array.Empty<string>;
        var array2 = new int[5] { 1, 2, 3, 4, 5 };
        //array2[1] = 1;

        var arrayCustom = new Custom[3];
        var arrayCustom2 = arrayCustom.Clone();
        arrayCustom[1] = new Custom() { Id = 123, Nome = "Jordan" };

        foreach (var item in array2)
            Console.WriteLine(item);

        foreach (Custom customItem in arrayCustom)
        {
            Console.WriteLine($"Id: {customItem.Id} / Nome: {customItem.Nome}");
        }

    }

    struct Custom
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }

}