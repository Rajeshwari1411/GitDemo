using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary14sep
{
    [Serializable()]
    public class Movies
    {
        public string moviename
        {
            get;
            set;
        }
        public string movielanguage
        {
            get;
            set;
        }
        public string moviegenre
        {
            get;
            set;
        }
        public int moviestock
        {
            get;
            set;
        }
        public Movies(string name, string language, string genre, int stock)
        {
            moviename = name;
            movielanguage = language;
            moviegenre = genre;
            moviestock = stock;
        }
        public Movies()
        {

        }
    }
    [Serializable()]
    public class Searchmovies
    {
        public List<Movies> Search
        {
            get;
            set;
        }
        public static List<Movies> movies=new List<Movies>();
        public List<Movies> AlreadySeen;

        public void initiate()
        {
            movies.Add(new Movies("Master","Tamil","Action",15));
            movies.Add(new Movies("Kaidhi","Tamil","Action",12));
            movies.Add(new Movies("The batman","English","Action",20));
            movies.Add(new Movies("The black phone","English","Horror",25));
            movies.Add(new Movies("Light year","English","Adventure",23));
        }
        public void search()
        {
            Console.WriteLine("Search by\n1.Name\n2.Language\n3.Genre");
            int i=Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 1:
                    Console.WriteLine("Enter the Movie Name to search:");
                    string j=Console.ReadLine();
                    var k=movies.Where(l=>l.moviename==j).ToList(); 
                    if(k!=null)
                    {
                        Search = k;
                    }
                    else
                    {
                        Console.WriteLine("The movie you search is unavailable");
                    }
                    break;

                    case 2:
                    Console.WriteLine("Enter the movie language to search:");
                    string m=Console.ReadLine();    
                    var n=movies.Where(l=>l.movielanguage==m).ToList();
                    if(n!=null)
                    {
                        Search=n;

                    }
                    else
                    {
                        Console.WriteLine("The movie you search is unavailable");
                    }
                    break ;
                case 3:
                    Console.WriteLine("Enter the movie genre to search:");
                    string o=Console.ReadLine();
                    var p=movies.Where(l=>l.moviegenre==o).ToList();
                    if(p!=null)
                    {
                        Search=p;
                    }
                    else
                    {
                        Console.WriteLine("The movie you search is unavailable");
                    }
                    break;
            }
        }
        public void AddMovies()
        {
            Movies q=new Movies();
            Console.WriteLine("Enter the movie name");
            q.moviename=Console.ReadLine();
            Console.WriteLine("Enter the movie language");
            q.movielanguage=Console.ReadLine();
            Console.WriteLine("Enter the movie genre");
            q.moviegenre=Console.ReadLine();
            Tuple<string,string,string>r=Tuple.Create<string,string,string>(q.moviename,q.movielanguage,q.moviegenre);
            Predicate<Tuple<string, string, string>> s = (t) =>

            {
                int flag = 0;
                foreach (var item in movies)
                {
                    if (item.moviename == t.Item1 && item.movielanguage == t.Item2 && item.moviegenre == t.Item3)
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            if(s(r))
            {
                Console.WriteLine("Lready exisits");
            }
            else
            {
                movies.Add(q);
            }

        }
        public void DeleteMovies()
        {
            Movies sr=new Movies();
            Console.WriteLine("Enter movie name");
            sr.moviename=Console.ReadLine();
            Console.WriteLine("Enter movie language");
            sr.movielanguage=Console.ReadLine();
            Console.WriteLine("Enter movie genre");
            sr.moviegenre=Console.ReadLine();
            foreach(var item in movies)
            {
                if(item.moviename==sr.movielanguage && item.movielanguage==sr.movielanguage && item.moviegenre==sr.moviegenre)
                {
                    movies.Remove(item);
                }
            }

                
        }
        public void DisplayMovies()
        {
            foreach(var item in movies)
            {
                Console.WriteLine($"{item.moviename} {item.movielanguage} {item.movielanguage}");
            }
        }
    }
    [Serializable()]
    public class CustomerUser : Searchmovies
    {
        public long Id { get; set; }
        public string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string login
        {
            get;
            set;
        }
        public DateTime date
        {
            get { return DateTime.Now; }
        }
        public bool validate()
        {
            if(Id==8111040669 && Password=="1234567890")
            {
                login = "true";
                return true;
            }
            else
            {
                login="false";
                return false;
            }
        }
        public List<Movies>AlreadySeen
        {
            get;
            set;
        }
        public IEnumerable<object> Alreadyseen { get; set; }
    }
    [Serializable()]
    public class Watch:Searchmovies
    {
        public List<Tuple<Movies,DateTime>>watchlist=new List<Tuple<Movies,DateTime>>();
        public List<Tuple<Movies,int>>release=new List<Tuple<Movies,int>>();
        public List<Tuple<string,int,double>>total=new List<Tuple<string,int,double>>();
        public void Addtowatchlist()
        {
            string rs=Console.ReadLine();
            var uv = movies.Where(R => R.moviename == rs).ToList();
            if (uv != null)
            {
                foreach(Movies item in uv)
                {
                    Console.WriteLine(item.moviename);
                    movies.Remove(item);
                    item.moviestock=item.moviestock-1;
                    Console.WriteLine("Enter the year");
                    int y1=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the month");
                    int mo1= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the date");
                    int d1=Convert.ToInt32(Console.ReadLine()); 
                    DateTime dt1=new DateTime(y1,mo1,d1);
                    Tuple<Movies,DateTime>hs=Tuple.Create<Movies,DateTime>(item,dt1);
                    movies.Add(item);
                    watchlist.Add(hs);
                }
            }
            else
            {
                Console.WriteLine("cannot be added");
            }
        }
        public void releaselist()
        {
            string hr=Console.ReadLine();
            Tuple<Movies, DateTime> mn = null;
            foreach(var item in watchlist)
            {
                if(hr==item.Item1.moviename)
                {
                    mn=item;
                    movies.Remove(item.Item1);
                    item.Item1.moviestock=item.Item1.moviestock+1;
                    Console.WriteLine("Enter the year");
                    int yr=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int mon=Convert.ToInt32(Console.ReadLine());    
                    Console.WriteLine("Enter thr date");
                    int date=Convert.ToInt32(Console.ReadLine());
                    DateTime dt=new DateTime(yr,mon,date);
                    TimeSpan TS = dt - item.Item2;
                    Tuple<Movies, int> pq = Tuple.Create<Movies, int>(item.Item1, TS.Days);
                    release.Add(pq);
                    movies.Add(item.Item1);
                }
            }
            watchlist.Remove(mn);
        }
        public void TotalCostAssociate(string ps)
        {
            int flag = 0;
            foreach(var item in release)
            {
                if(ps==item.Item1.moviename)
                {
                    flag = 1;
                    Console.WriteLine(item.Item1.moviename);
                    Console.WriteLine("Enter the cost of 1 day");
                    double cost = Convert.ToInt32(Console.ReadLine());
                    double mb=0.18*cost;
                    double ma=item.Item2*0.01*cost;
                    double nm = mb + ma + cost;
                    Console.WriteLine($"GST IS {mb}");
                    Console.WriteLine($"Blueray cost is {ma}");
                    Tuple<string, int, double> k1 = Tuple.Create(item.Item1.moviename, item.Item2, nm);
                    total.Add(k1);
                }
            }
            foreach(var item in watchlist)
            {
                if(ps==item.Item1.moviename)
                {
                    Console.WriteLine("Enter cost of 1 day");
                    double cost=Convert.ToInt32(Console.ReadLine());
                    TimeSpan ts = DateTime.Now - item.Item2;
                    double mb = 0.18 * cost;
                    double ma = (ts.Days) * 0.01 * cost;
                    double nm = mb + ma + cost;
                    Console.WriteLine($"GST IS {mb}");
                    Console.WriteLine($"Blueray cost is {ma}");
                    Console.WriteLine("Total cost is" + "" + ma);
                    Tuple<string, int, double> k1 = Tuple.Create(item.Item1.moviename, ts.Days, nm);
                    total.Add(k1);

                }
                else if(flag!=1)
                {
                    foreach(var item1 in movies)
                    {
                        if(ps==item1.moviename)
                        {
                            Console.WriteLine(item1.moviename);
                            Console.WriteLine("Enter the cost of 1 day");
                            double cost= Convert.ToInt32(Console.ReadLine());
                            double mb = 0.18 * cost;
                            double ma = 0 * 0.01 * cost;
                            double nm = mb + ma + cost;
                            Console.WriteLine($"GST IS {mb}");
                            Console.WriteLine($"Blueray cost is {ma}");
                            Console.WriteLine("Total cost is" + "" + ma);
                            Tuple<string, int, double> k1 = Tuple.Create(item.Item1.moviename, 0, nm);
                            total.Add(k1);

                        }
                    }
                }
            }  
        }

       
    }
}
