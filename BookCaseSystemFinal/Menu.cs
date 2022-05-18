using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystemFinal
{
    public class Menu
    {
        public string Input { get; set; }
        public void Show()
        {
            //opretter et reollejer liste objekt
            BookCaseOwnerList ownerList = new BookCaseOwnerList();
            //opretter et menu objekt
            //Kører en endless loop (senere burde der tilføjes et afslutningspunkt)
            while (true)
            {
                //Opretter 2 menu punkter
                MenuCreate("Udskriv liste", 1);
                MenuCreate("Opret reollejer", 2);
                //Tildeler variable menu.Input en Console.ReadLine for at få bruger input i vores variable
                Input = Console.ReadLine();
                //Opretter en switch som tager vores menu.Input ind som parameter (den tjekker hvad bruger har skrevet)
                switch (Input)
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

        public void MenuCreate(string Title, int menuID)
        {
            Console.WriteLine(menuID+"." + " " + Title);
        }

    }
}
