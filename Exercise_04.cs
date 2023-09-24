using System;
using System.Collections.Generic;
using System.Linq;
					
public class Exercise_04
{
	public static void Exercise()
	{
		Console.WriteLine("Please, insert five numbers");
		
		List<float> values = new List<float>();
		do{
			float value;
			Console.WriteLine("Insert a value: ");
			if(float.TryParse(Console.ReadLine(), out value)){
				values.Add(value);
			}
			else{
				Console.WriteLine("Please, insert a valid value");
			}
		}
		while(values.Count <= 4);
		
		float sum = values.Sum();
		float average = sum/values.Count();
		Console.WriteLine($"The sum of the numbers are {sum} and the average {average}");
		
	}
}