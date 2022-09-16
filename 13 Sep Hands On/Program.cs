using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;

namespace sep13handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.AddMovieDetails("Don", "Tamil", "Drama", 20);
            Movie m2 = new Movie();
            m2.AddMovieDetails("Fidaa", "Tamil", "Romance", 30);
            Movie m3 = new Movie();
            m3.AddMovieDetails("master", "Tamil", "Action", 40);
            Movie m4 = new Movie();
            m4.AddMovieDetails("VVS", "Tamil", "Comedy", 50);
            Movie m5 = new Movie();
            m5.AddMovieDetails("Thuppakii", "Tamil", "Action", 60);
            Movie m6 = new Movie();
            m6.AddMovieDetails("Kaidhi", "Tamil", "Action", 80);
            Movie m7 = new Movie();
            m7.AddMovieDetails("Kanchana", "Tamil", "Horror", 70);
            Movie m8 = new Movie();
            m8.AddMovieDetails("24", "Tamil", "Action", 90);
            Movie m9 = new Movie();
            m9.AddMovieDetails("Dheran", "Tamil", "Action", 100);
            Movie m10 = new Movie();
            m10.AddMovieDetails("VIP1", "Tamil", "Drama", 120);
            Movie m11 = new Movie("KMP", "Tamil", "Comedy", 110);
            User u1 = new User();
            User u2 = new User();
            User u3 = new User();
            User u4 = new User();
            User u5 = new User();
            User u6 = new User();
            User u7 = new User();
            User u8 = new User();
            User u9 = new User();
            User u10 = new User();
            User u11 = new User();
            User u12 = new User();
            User u13 = new User();

            u2.AddUser("Anand", "Varun", "Silver");
            u3.AddUser("Anand", "Varun", "Silver");
            u4.AddUser("Anand", "Varun", "Silver");
            u5.AddUser("Anand", "Varun", "Silver");
            u6.AddUser("Anand", "Varun", "Silver");
            u7.AddUser("Anand", "Varun", "Silver");
            u8.AddUser("Anand", "Varun", "Silver");
            u9.AddUser("Anand", "Varun", "Silver");
            u10.AddUser("Anand", "Varun", "Silver");
            u12.AddUser("Anand", "Varun", "Silver");
            u13.AddUser("Anand", "Varun", "Silver");
            //u14.AddUser("Anand", "Varun", "Silver");
            //u15.AddUser("Anand", "Varun", "Silver");
            u1.BorrowMovie(m1);
            u2.BorrowMovie(m1);
            u4.BorrowMovie(m1);
            Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u2.RetrunMovie(m1, 4);
            Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u3.BorrowMovie(m1);
            u6.BorrowMovie(m1);
            u5.BorrowMovie(m1);
            u7.BorrowMovie(m1);
            u8.BorrowMovie(m1);
            u9.BorrowMovie(m1);
            u10.BorrowMovie(m1);
            u12.BorrowMovie(m1);
            u11.BorrowMovie(m1);
            u13.BorrowMovie(m1);
            u1.BorrowMovie(m2);
            u1.RetrunMovie(m2, 5);
            u1.BorrowMovie(m3);
            Console.WriteLine("=================================================");
            u1.ShowMyList();
            Console.WriteLine("==================================================");
            u1.SearchByLanguage("Tamil");
            Console.WriteLine("==================================================");
            u1.SearchByGenre("Romance");
            // m1.PrintAllMovies();

        }
    }
}


