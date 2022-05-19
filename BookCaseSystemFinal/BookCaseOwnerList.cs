using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystemFinal
{
    public class BookCaseOwnerList
    {

        //Laver en ny liste af BookCaseOwner ved navn bookCaseOwnerList
        List<BookCaseOwner> bookCaseOwnerList = new List<BookCaseOwner>();
        
        //Opretter PrintList metode som kommer til at styre vores liste
        public void PrintList()
        {
            //Laver en if statement, som skriver "listen er tom" når der ikke findes nogen reollejere
            if (bookCaseOwnerList.Count == 0)
            {
                Console.WriteLine("Listen er tom");
            }
            //For loop som iterere bookCaseOwnerList igennem og udskriver Navn, Email, Telefon og ID til consolen.
            for (int bookCaseOwnerCount = 0; bookCaseOwnerCount < bookCaseOwnerList.Count; bookCaseOwnerCount++)
            {
                Console.WriteLine($"Index: {bookCaseOwnerCount}\nNavn: {bookCaseOwnerList[bookCaseOwnerCount].Name}\nEmail: {bookCaseOwnerList[bookCaseOwnerCount].Email}\nTelefon: {bookCaseOwnerList[bookCaseOwnerCount].Phone}\nID: {bookCaseOwnerList[bookCaseOwnerCount].BookCaseOwnerID}\n");
            }
        }
        //Show list, som printer vores PrintList metode.
        public void ShowList()
        {
            PrintList();
        }
        //Opretter en ny reollejer metode
        public void CreateBookCaseOwner()
        {
            //Beder brugeren indtaste informationerne på den nye reollejer
            try
            {
                Console.WriteLine("Indtast navn: ");
                string name = Console.ReadLine();
                Console.WriteLine("Indtast email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Indtast phone: ");
                int phone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast ID: ");
                int bookCaseOwnerId = Convert.ToInt32(Console.ReadLine());
                //Tilføjer vores nye reollejer objekt til vores bookCaseOwnerList
                bookCaseOwnerList.Add(new BookCaseOwner() { Name = name, Email = email, Phone = phone, BookCaseOwnerID = bookCaseOwnerId });
            }
            catch (Exception)
            {
                Console.WriteLine("Forkert Input\nTryk på 'Enter' for at forsøge igen");
                Console.ReadLine();

            }
        }
    }
}
