using System;
					
public class Exercise_02
{
	public static void Exercise()
	{
		Console.WriteLine("Insert a username and password to proceed");
		String username = "", password = "";
		do{
			Console.Write("Insert a username: ");
			username = Console.ReadLine();
			Console.Write("Insert a password: ");
			password = Console.ReadLine();
		}
		while(username == password);
		
		Console.Write("Thanks");
	}
}