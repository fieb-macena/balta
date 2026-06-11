namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
                Console.Clear();
                //Console.BackgroundColor = ConsoleColor.Blue;
                //Console.ForegroundColor = ConsoleColor.White; 

                DrawCanvas();
                DrawOptions();
                short option = short.Parse(Console.ReadLine());
                HandleMenuOption(option);
        }

        public static void DrawCanvas()
        {
            var colunas = 50;
            var linhas = 15;
            Header(colunas);
            Body(colunas, linhas);
            Header(colunas);

        }

        static void Header(int colunas = 30)
        {   
            Console.Write("+");
            for (int i = 0; i < colunas; i++)
                Console.Write("-");
            Console.Write("+");
            Console.WriteLine();
        }

        static void Body(int colunas = 30, int linhas = 10)
        {
            for (int i = 0; i < linhas; i++)
            {
                Console.Write("|");
                for (int j = 0; j < colunas; j++)
                    Console.Write(" ");
                Console.Write("|");
                Console.WriteLine();
            }
        }

        static void DrawOptions()
        {
            Console.SetCursorPosition(15, 2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(2, 4);
            Console.Write("================================");
            Console.SetCursorPosition(2, 5);
            Console.Write("Selecione uma opção:");
            Console.SetCursorPosition(2, 6);
            Console.Write("1 - Abrir arquivo");
            Console.SetCursorPosition(2, 7);
            Console.Write("2 - Novo arquivo");
            Console.SetCursorPosition(2, 8);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(2, 9);
            Console.Write("Opção desejada: ");
            Console.SetCursorPosition(18,9);
            
        }

        static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Viewer.Read();
                    Show();
                    break;
                case 2: 
                    Editor.Write(); 
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}