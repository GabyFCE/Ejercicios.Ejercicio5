// See https://aka.ms/new-console-template for more information



Console.WriteLine("Escribe algo y presiona Ctrl+F para finalizar el programa.");

while (true)
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    if (keyInfo.Modifiers == ConsoleModifiers.Control && keyInfo.Key == ConsoleKey.F)
    {
        Console.WriteLine("\nPrograma finalizado.");
        break;
    }
    else
    {
        Console.Write(keyInfo.KeyChar);
    }
}
    



