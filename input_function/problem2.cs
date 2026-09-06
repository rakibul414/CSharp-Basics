using System;

public class problem2
{
	public static void run()
	{
		Console.Write("Enter a number  ");
		int a = int.Parse(Console.ReadLine());
		double b = a;
		Console.WriteLine("Enter Another number  " );

		int c = int.Parse(Console.ReadLine());
		double d = c;

		Console.WriteLine($"{b} + {d} =  {b + d}");
		Console.WriteLine($"{b} - {d} =  {b - d}");
		Console.WriteLine($"{b} X {d} =  {b * d}");
        Console.WriteLine($"{b} / {d} =  {b / d}");

    }
}
