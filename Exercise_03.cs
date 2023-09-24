using System;
					
public class Exercise_03
{
	public static void Exercise()
	{
		Console.WriteLine("Insert a username and password to proceed");
		String username = "";
		int age = 0;
		float salary = 0;
		char sex;
		char civilState;
		do{
			Console.Write("Insert a username: ");
			username = Console.ReadLine();
			Console.Write("Insert a age: ");
			int.TryParse(Console.ReadLine(), out age);
			Console.Write("Insert a salary: ");
			float.TryParse(Console.ReadLine(), out salary);
			Console.Write("Insert a gender [f/m]: ");
			sex = char.Parse(Console.ReadLine());
			Console.Write("Insert a civil state [s/c/v/d]: ");
			civilState = char.Parse(Console.ReadLine());
			
			if(!Validade(username, age, salary, sex, civilState)){
				Console.WriteLine("Invalid data, please insert the data again\n");
			}
		}
		while(!Validade(username, age, salary, sex, civilState));
		
		Console.Write("Thanks");
	}

	public static bool Validade(string username, int age, float salary, char sex, char civilState){
		return username.Length <= 3 && ValidateAge(age) && ValidateSalary(salary) &&
										ValidateSex(sex) && ValidateCivilState(civilState);
	}
	
	public static bool ValidateAge(int age){
		return age > 0 && age < 150;
	}
	
	public static bool ValidateSalary(float salary){
		return salary > 0;
	}

	public static bool ValidateSex(char sex){
		return sex == 'f' || sex == 'm';
	}

	public static bool ValidateCivilState(char state){
		return state == 's' || state == 'c' || state == 'v' || state == 'd';
	}
}