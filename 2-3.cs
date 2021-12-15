using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Age");
		int age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Sexe (h/f)");
		string gender = Console.ReadLine();
		string sexPart = "une chose ";
		string agePart = "moy";
		string sexEnd = "eur.e.";
		if (age >=18) 
		{
			agePart = "maj";
		} else 
		{
			agePart = "min";
		}
		if ( gender == "h")
		{
			sexPart = "un homme ";
			sexEnd = "eur.";
		} else if (gender == "f") 
		{
			sexPart = "une femme ";
			sexEnd = "eure.";
		}
		Console.WriteLine("Vous êtes " + sexPart + "et vous êtes " + agePart + sexEnd);
	}
}