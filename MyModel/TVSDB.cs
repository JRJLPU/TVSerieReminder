using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDatabase
{
        public class TVSDB
        {
            private readonly List<SerieInfo> _seriesList = new List<SerieInfo>();
            public TVSDB()
            {
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Pilot", Season = 1, AirTime = DateTime.Parse("29-09-2015") });
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Wendigo", Season = 1, AirTime = DateTime.Parse("30-09-2015") });
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Dead in the Water", Season = 1, AirTime = DateTime.Parse("01-10-2015") });
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Phantom Traveler", Season = 1, AirTime = DateTime.Parse("02-10-2015") });
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Bloody Mary", Season = 1, AirTime = DateTime.Parse("03-10-2015") });
            }
            public List<SerieInfo> GetAllSeries()
            {
                return _seriesList;
            }
            public List<SerieInfo> SearchSeries(string title)
            {
                var index = _seriesList.FindAll(x => x.Name == title);
                return index;
            }


        }
}
