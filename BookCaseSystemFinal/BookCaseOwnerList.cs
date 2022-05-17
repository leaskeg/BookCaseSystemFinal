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
        int counter { get; set; } = 0;
        public void PrintList()
        {
            for (int i = 0; i < bookCaseOwnerList.Count; i++)
            {
                Console.WriteLine($"Index: {i} Navn: {bookCaseOwnerList[0].Name}");

            }
        }

        public void ShowList()
        {
            PrintList();
        }

        public void CreateBookCaseOwner(string name, string email, int phone, int id)
        {
            bookCaseOwner.Name = name;
            bookCaseOwner.Email = email;
            bookCaseOwner.Phone = phone;
            bookCaseOwner.ID = id;
            bookCaseOwnerList.Add(bookCaseOwner);
            counter++;
        }

    }



}
