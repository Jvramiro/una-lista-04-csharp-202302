using System;
					
public class Exercise_01
{
	public static void Exercise()
	{
		Console.WriteLine("Insert a value between 0 and 10");
		float value;
		
		while(true){
			if(float.TryParse(Console.ReadLine(), out value) && value >= 0 && value <= 10){
				Console.WriteLine("Thanks");
				break;
			}
			else{
				Console.WriteLine("Please, insert a valid value");
			}
		}
	}
}