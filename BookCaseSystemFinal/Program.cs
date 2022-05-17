using System;

namespace BookCaseSystemFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCaseOwnerList ownerList = new BookCaseOwnerList();

            /*ownerList.CreateBookCaseOwner("Kenneth", "Kenneth@IO.dk", 12345678, 77777);
            ownerList.CreateBookCaseOwner("Hans", "Hans@IO.dk", 23456789, 66666);
            ownerList.CreateBookCaseOwner("Ruth", "Ruth@IO.dk", 34567890, 55555);
            ownerList.CreateBookCaseOwner("Thomas", "Thomas@IO.dk", 45678901, 44444);
            ownerList.CreateBookCaseOwner("Erik", "Erik@IO.dk", 56789012, 333333);
            ownerList.CreateBookCaseOwner("Lene", "Lene@IO.dk", 67890123, 22222);
            */
            ownerList.CreateBookCaseOwner();
            ownerList.ShowList();


                Console.ReadLine();
        }
    }
}
