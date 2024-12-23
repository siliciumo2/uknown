using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите цифру 1 для открытия блокнота");
        string userInput = Console.ReadLine();
        if (userInput == "1")
        {
            System.Diagnostics.Process.Start("notepad.exe");
            Console.WriteLine("Блокнот открыт");
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
}