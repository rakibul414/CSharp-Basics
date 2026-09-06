using System;

public class Problem3
{
	public static void run()
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"previously\n a == {a}\n b == {b}");

		int temp = a;
		a = b;
		b = temp;

		Console.WriteLine($"after swapping\n a == {a}\n b == {b}"); 

    }
}
