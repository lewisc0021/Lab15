using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountriesTextFile
    {
        //1.
        public static List<string> Load()
        {
            List<string> CountryList = new List<string>();

            string fileLocation = "../../countries.txt";

            StreamReader reader = new StreamReader(fileLocation); 

            string Data = reader.ReadToEnd().Trim();

            string[] Records = Data.Split('\n');

            foreach (string record in Records)
            {
                
                CountryList.Add(record);
            }
            reader.Close();
            return CountryList;
        }

        //2.
        public static List<string> addCountry(string country,List<string>CountryList)
        {
            CountryList.Add(country);
            return CountryList;
        }

        //3.
        public static void displayCountries(List<string> CountryList)
        {
            foreach (string record in CountryList)
            {
                Console.WriteLine(record);
            }
        }

        //4.
        public static void Save(List<string> CountryList)
        {
            StreamWriter writer = new StreamWriter("../../countries.txt", true);
            foreach (string record in CountryList)
            {
                writer.WriteLine(record);
            }
            writer.Close();
        }

    }
}
