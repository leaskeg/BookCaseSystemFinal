using System;

namespace BookCaseSystemFinal
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //opretter et reollejer liste objekt
            BookCaseOwnerList ownerList = new BookCaseOwnerList();
            //opretter et menu objekt
            Menu menu = new Menu();
            //Kører en endless loop (senere burde der tilføjes et afslutningspunkt)
            while (true)
            {
                //Opretter 2 menu punkter
                menu.MenuCreate("Udskriv liste", 1);
                menu.MenuCreate("Opret reollejer", 2);
                //Tildeler variable menu.Input en Console.ReadLine for at få bruger input i vores variable
                menu.Input = Console.ReadLine();
                //Opretter en switch som tager vores menu.Input ind som parameter (den tjekker hvad bruger har skrevet)
                switch (menu.Input)
                {
                    //Case 1 viser den liste af reollejer
                    case "1":
                        ownerList.ShowList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //Opretter vi en ny reollejer
                    case "2":
                        ownerList.CreateBookCaseOwner();
                        Console.Clear();
                        break;
                    //Hvis brugeren trykker på noget forkert, får de denne besked
                    default:
                        Console.WriteLine("Forkert valg\nTryk enter for at prøve igen");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
