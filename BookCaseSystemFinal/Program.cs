using System;

namespace BookCaseSystemFinal
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Opretter et nyt menu objekt
            Menu menu = new Menu();
            //Kalder metoden Show i vores menu objekt
            menu.Show();
        }
    }
}
