using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerieDatabase;

namespace SeriesReminderConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {

            TVSDB database = new TVSDB();
            
            SeriesReference.Service1Client client = new SeriesReference.Service1Client();
            var x = client.GetAllSeries();
            var c = x;
           
           
            Console.WriteLine("Søg efter serie: ");
            string search = Console.ReadLine();

            Console.WriteLine(database.Timer("10-10-2015 22:00"));
            
            //Console.WriteLine(database.SearchSeries(search));
            
            Console.ReadLine();
        }
        
    }
}
