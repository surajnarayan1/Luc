using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Tavisca.LucenaSearch;


namespace LucenaConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            List<SampleInformation> HotelList = SampleDataSearch.GetAll();
            LuceneSearch.AddUpdateLuceneIndex(HotelList);
            Console.WriteLine("WelCome to the world of lucena");
            while(true)
            {
                Console.WriteLine("Enter the Search Query");
                string querry = Console.ReadLine();
                IEnumerable<SampleInformation> HotelCount = LuceneSearch._search(querry);
                foreach (SampleInformation hotelInfo in HotelCount)
                {
                  
                    Console.WriteLine($"The Hotel Id-> :{hotelInfo.id}The Hotel Type:{hotelInfo.type}Hotel-Description:{hotelInfo.Description}");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
