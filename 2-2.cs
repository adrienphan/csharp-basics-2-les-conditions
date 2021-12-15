using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("age :");
		int age = Convert.ToInt32(Console.ReadLine());
		if (age >= 18)
		{
			Console.WriteLine("Vous avez " + age + "ans, vous etes donc majeur.e");
		} else 
		{
			Console.WriteLine("Vous avez " + age + "ans, vous etes donc mineur.e");
		}
	}
}