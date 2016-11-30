using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myCountries = CountriesTextFile.Load();
            Console.WriteLine("Welcome to Country Reader/Writer");
            Console.WriteLine("Here are your options:");
            Console.WriteLine("Enter 1 : Read Countries");
            Console.WriteLine("Enter 2 : Write Countries");
            Console.WriteLine("Enter 3 : Quit the application");
            while (true)
            {
            Console.WriteLine("Please enter your choice");
            int userChoice = int.Parse(Console.ReadLine());
            string countryName = "";
            if (userChoice == 1)
            {
                Console.WriteLine("Let's read");
                CountriesTextFile.displayCountries(myCountries);

            }

            else if (userChoice == 2)
            {
                Console.WriteLine("Let's write");
                Console.WriteLine("Please enter a country.");
                countryName = Console.ReadLine().Trim().ToLower();
                CountriesTextFile.addCountry(countryName, myCountries);
                }

            else if (userChoice == 3)
             {
                Console.WriteLine("Goodbye");
                CountriesTextFile.Save(myCountries);
                break;
             }

            }
        }//MAIN
    }//CLASS
}//N.S.