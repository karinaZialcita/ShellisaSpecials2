using System;

namespace DelegatesDemo
{
    class Program
    {

        delegate void showMovies(string[][] titles);
        static void showGMovies(string[][] titles)
        {                    //singular in plural
            foreach(string[] title in titles)
            {
                if (title[1].Equals("g")) // same sa == "g"
                    Console.WriteLine($"Movie title: {title[0]}");
            }
        }
        static void showPG13Movies(string[][] titles)
        {
            foreach (string[] title in titles)
                Console.WriteLine($"Movie title: {title[0]}");
            
        }

        static void Main(string[] args)
        {
            //delegate called nowPlaying
            showMovies nowPlaying;

            string[][] movies = { new string[] {"titanic", "g" },
                                   new string[]{"iron man", "g"},
                                   new string[]{"star wars" , "g"},
                                   new string[]{"witches", "pg13"},
                                   new string[]{"saw", "pg13" }
            };

            int age = 0;

            Console.WriteLine("Please enter your age ");
            age = Convert.ToInt32(Console.ReadLine());


            //the functions that will run depends on the age condition given
            if(age >= 13)
            {
                //display pg13 movies         //passing the name of the function not callling it
                nowPlaying = new showMovies(showPG13Movies);
            } else
            {
                //display g movies
                nowPlaying = new showMovies(showGMovies);
            }


            //we run the delegate even though we dont know which method will be invoked
            //pass array movies
            nowPlaying(movies);
        }
    }
}
