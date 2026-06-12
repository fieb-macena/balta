namespace Diversos;

public static class Exceptions
{
    public static void Show()
    {
        var arrayTeste = new int[3];

        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayTeste[i]);
            }
        }
        catch (CustomException ce)
        {
            Console.WriteLine(ce.Horario);
        }
        finally
        {
            Console.WriteLine("Final");
        }

    }

    public class CustomException : Exception
    {
        public CustomException(DateTime dt)
        {
            DateTime Horario = dt;
        }

        public DateTime Horario
        {
            get; set;
        }

    }
}