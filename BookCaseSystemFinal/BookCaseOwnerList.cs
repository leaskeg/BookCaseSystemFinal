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
                Console.WriteLine($"Index: {i} Navn: {bookCaseOwnerList[i].Name} Email: {bookCaseOwnerList[i].Email} ");

            }
        }

        public void ShowList()
        {
            PrintList();
        }

        public void CreateBookCaseOwner(string name, string email, int phone, int id)
        {

            bookCaseOwnerList.Add(new BookCaseOwner() { Name = name, Email = email, Phone = phone });
            counter++;
        }

    }



}
