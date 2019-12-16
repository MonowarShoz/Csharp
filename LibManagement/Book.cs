using System;
using System.Collections.Generic;
using System.Text;

namespace LibManagement
{
    class Book
    {
        public string bookCode { get; set; }
        public string bookName { get; set; }
        public string writer { get; set; }
        public int stock { get; set; }

        public Book(string bc,string bn,string wt,int st)
        {
            bookCode = bc;
            bookName = bn;
            writer = wt;
            stock = st;
        }
        public void Show()
        {
            Console.Write("code " + bookCode);
            Console.WriteLine("\t book NAme " + bookName);
            Console.WriteLine("\t writer " + writer);
            Console.WriteLine("\t Stock " + stock);

        }

    }
}
