using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    internal class Cart:Book
    {
        private int _custid;

        public int CustomerId
        {
            get { return _custid; }
            set { _custid = value; }
        }
        private int _bookingid;

        public int BookingID
        {
            get { return _bookingid; }
            set { _bookingid = value; }
        }

        static int bookcount;
        public void BookCount()
        {
            bookcount = bookcount + 1;
            Console.WriteLine("Count of Books in Cart: " + bookcount);
        }

        public void AddToCart(int custid, int bookid, int price)
        {
            this.CustomerId = custid;
            this.BookingID = bookid;
            this.Price = price;
        }

    }
}
