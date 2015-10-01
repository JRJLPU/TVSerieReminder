using SerieDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace SerieReminder
{
    public class Service1 : IService1
    {
        TVSDB tvListe = new TVSDB();

        public Dictionary<string, int> GetAllSeries(string test)
        {
            return tvListe.GetAllSeries(test);
        }
        public List<SerieInfo> SearchSeries(string title)
        {
            return tvListe.SearchSeries(title);
        }
        public string Timer(DateTime timeToWatch, string episode, string serie)
        {
            return tvListe.Timer(timeToWatch, episode, serie);
        }

    }
}
