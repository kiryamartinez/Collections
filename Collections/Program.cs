using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> country = new Dictionary<string, int>();
            country.Add("Россия",1);
            country.Add("Казахстан",2);
            country.Add("Украина",3);
            country.Add("Белоруссия",4);

            FindNubmer(country, "Казахстан");
        }
        static void FindNubmer(Dictionary<string,int> country, string nameCountry)
        {
            if (country.ContainsKey(nameCountry))
            {
                Console.WriteLine(country[$"{nameCountry}"]);
            }
            else
            {
                Console.WriteLine("Данной страны нет");
            }
        }
    }
}
