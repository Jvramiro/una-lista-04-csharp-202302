using System;
					
public class Exercise_06
{
	public static void Exercise()
	{
		Console.WriteLine("Insert the first integer number: ");
		int first = int.Parse(Console.ReadLine());
		Console.WriteLine("Insert the second integer number: ");
		int second = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Numbers:");
		
		for(int i = Math.Min(first, second) + 1; i < Math.Max(first, second); i++){
			Console.WriteLine(i);
		}
	}
}