// See https://aka.ms/new-console-template for more information

    Console.WriteLine("Ingrese lo que quiera, el programa finalizará con ctrl+F");
ConsoleKeyInfo c;
while ((c = Console.ReadKey()).Modifiers != ConsoleModifiers.Control
       || c.Key != ConsoleKey.F) { } //Exit on Ctrl + F

