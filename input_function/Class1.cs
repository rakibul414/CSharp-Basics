using System;

public class problem1
{
	public static void run()
	{
        Console.Write("Enter Your Name  :  ");

        string name = Console.ReadLine();

        Console.Write("What is your age?  ");

        int age = int.Parse(Console.ReadLine());

        Console.Write("what is your blood group? ");

        string blood = Console.ReadLine();

        Console.Write("What is your weight? ");

        double weight = double.Parse(Console.ReadLine());

        Console.Write("Are you student?  ");

        string std = Console.ReadLine();

        std.ToLower();
        bool ok = (std == "yes");

        Console.WriteLine($"Hello {name}! You are {age} years old.\r\nBlood Group: {blood}, Weight: {weight} kg.\r\nStudent Status: {ok}");


    }
}
