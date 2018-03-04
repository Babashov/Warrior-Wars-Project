using System;
namespace Warrior_Wars
{
    static class Tools
    {
        static public void colorfull(string text,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
