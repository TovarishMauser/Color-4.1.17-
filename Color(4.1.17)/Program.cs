using System;

class MainClass
{    
    static string ShowColor(string name)
    {
        Console.WriteLine(name + " Напишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        
        return color;
    }

    public static void Main(string[] args)
    {
        string[] favcolors = new string[3];
       (string name, int age) anketa;
        /*
        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);
        */
        Console.Write("Введите имя: ");
        anketa.name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ваше имя: {0}", anketa.name);
        Console.WriteLine(" Ваш возраст: {0}", anketa.age);

        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor(anketa.name);
        }

        Console.WriteLine("Ваши любимые цвета");
        foreach (var color_ in favcolors)
        {
            Console.WriteLine(color_);
        }
    }
}