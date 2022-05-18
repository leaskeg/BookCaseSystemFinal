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

        }

        public void MenuCreate(string Title, int menuID)
        {
            Console.WriteLine(menuID+"." + " " + Title);
        }

    }
}
