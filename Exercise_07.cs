using System;
using System.Collections.Generic;
					
public class Exercise_07
{
	public static void Exercise()
	{
		Console.WriteLine("Insert 10 integer numbers");
		List<int> values = new List<int>();
		for(int i = 0; i < 10; i++){
			values.Add(int.Parse(Console.ReadLine()));
		}
		
		var even = values.FindAll(c=> c%2 == 0);
		var odd = values.FindAll(c=> c%2 != 0);
		Console.WriteLine($"Even numbers: {even.Count} \nOdd Numbers: {odd.Count}");
	}
}