using SerieDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesReminderConsole2
{
    class Program
    {
        static void Main(string[] args)
        {

            TVSDB database = new TVSDB();

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            var x = client.GetAllSeries();
            var c = x;


            Console.WriteLine("Søg efter serie: ");
            string search = Console.ReadLine();
            DateTime test = new DateTime(2015, 10, 12, 22, 05, 00);

            //Console.WriteLine(database.Timer(test));
             
            Console.WriteLine(database.SearchSeries(search));

            Console.ReadLine();
        }
    }
}
