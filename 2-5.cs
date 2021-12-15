using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Renseignez un mois :");
      string month = Console.ReadLine();
      if (month == "décembre"|| month == "janvier" || month == "février")
      {
         Console.WriteLine("la saison du mois saisi est l'HIVER");
      } else if (month == "mars"|| month == "avril" || month == "mai")
      {
         Console.WriteLine("la saison du mois saisi est le PRINTEMPS");
      } else if (month == "juin"|| month == "juillt" || month == "août")
      {
         Console.WriteLine("la saison du mois saisi est l'ETE");
      } else if (month == "septembre"|| month == "octobre" || month == "novembre")
      {
         Console.WriteLine("la saison du mois saisi est l'AUTOMNE");
      } else Console.WriteLine("je n'ai pas compris parce que je suis un bête ordinateur");
	}
}