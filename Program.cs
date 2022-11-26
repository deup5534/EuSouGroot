
    Console.WriteLine("--- Groot Chatbot ---");
    Console.WriteLine("\nConverse com Groot!");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
    Console.ResetColor();
string conversa ="";

while (conversa != "Tchau" )
{
    Console.Write(">");
    Console.ReadLine();
    RespostaDoGroot();
}

void RespostaDoGroot()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nEu sou Groot.");
    Console.ResetColor();
}
