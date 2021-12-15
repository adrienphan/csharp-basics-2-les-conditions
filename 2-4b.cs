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
		bool loginOk = false;
		bool passwordOk = false;
		switch (loginAttpt){
			case "admin":
				loginOk = true;
				break;
			default:
				loginOk = false;
				break;
		}
		switch (password){
			case "password123":
				passwordOk = true;
				break;
			default:
				passwordOk = false;
				break;
		}
		if (loginOk && passwordOk){
			Console.WriteLine("Bienvenue à la Manu.");
		} else {
			Console.WriteLine(" Mauvais identifiant ou mauvais mot de passe. ");
		}
	}
}