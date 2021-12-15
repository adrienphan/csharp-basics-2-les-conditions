using System;
					
public class Program
{
	public static void Main()
	{
		string login = "admin";
		string password = "password123";
		Console.WriteLine("Log in :");
		string loginAttpt = Console.ReadLine();
		Console.WriteLine("Password :");
		string passwordAttpt = Console.ReadLine();
		if (loginAttpt == login && passwordAttpt == password)
		{
			Console.WriteLine("Bienvenue à la Manu");
		} else 
		{
			Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
		}
	}
}