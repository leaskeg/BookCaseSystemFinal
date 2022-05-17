using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystemFinal
{
    public class BookCaseOwnerList
    {

        BookCaseOwner bookCaseOwner = new BookCaseOwner();
        List<BookCaseOwner> bookCaseOwnerList = new List<BookCaseOwner>();
        
        //int counter { get; set; } = 0;
        public void PrintList()
        {
            for (int bookCaseOwnerCount = 0; bookCaseOwnerCount < bookCaseOwnerList.Count; bookCaseOwnerCount++)
            {
                Console.WriteLine($"Index: {bookCaseOwnerCount}\nNavn: {bookCaseOwnerList[bookCaseOwnerCount].Name}\nEmail: {bookCaseOwnerList[bookCaseOwnerCount].Email}\nTelefon: {bookCaseOwnerList[bookCaseOwnerCount].Phone}\nID: {bookCaseOwnerList[bookCaseOwnerCount].BookCaseOwnerID}\n");

            }
        }

        public void ShowList()
        {
            PrintList();
        }

        /*public void CreateBookCaseOwner(string name, string email, int phone, int bookCaseOwnerId)
        {
            
            bookCaseOwnerList.Add(new BookCaseOwner() { Name = name, Email = email, Phone = phone, BookCaseOwnerID = bookCaseOwnerId });
            //counter++;
        }
        */
        public void CreateBookCaseOwner()
        {
            Console.WriteLine("Indtast navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Indtast phone: ");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast ID: ");
            int bookCaseOwnerId = Convert.ToInt32(Console.ReadLine());
            bookCaseOwnerList.Add(new BookCaseOwner() { Name = name, Email = email, Phone = phone, BookCaseOwnerID = bookCaseOwnerId });
            //counter++;
        }

    }



}
