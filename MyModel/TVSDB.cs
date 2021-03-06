﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SerieDatabase
{
        public class TVSDB
        {
            public readonly List<SerieInfo> _seriesList = new List<SerieInfo>();
            public TVSDB()
            {
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Pilot", Season = 1, AirTime = DateTime.Parse("29-09-2016 22:00") });
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Wendigo", Season = 1, AirTime = DateTime.Parse("30-09-2016 22:00") });
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Dead in the Water", Season = 1, AirTime = DateTime.Parse("01-10-2016 22:00" ) });
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Phantom Traveler", Season = 1, AirTime = DateTime.Parse("02-10-2016 22:00") });
                _seriesList.Add(new SerieInfo { Name = "Supernatural", EpisodeName = "Bloody Mary", Season = 1, AirTime = DateTime.Parse("03-10-2016 22:00" ) });
                _seriesList.Add(new SerieInfo { Name = "Friends", EpisodeName = "The one with Joey", Season = 1, AirTime = DateTime.Parse("06-10-2016 19:30") });
                _seriesList.Add(new SerieInfo { Name = "Friends", EpisodeName = "The one with Ross", Season = 1, AirTime = DateTime.Parse("07-10-2016 19:30") });
            }
            public Dictionary<string, int> GetAllSeries()
            {
                Dictionary<string, int> seriesName = new Dictionary<string, int>();
                foreach (SerieInfo info in _seriesList)
                {
                    if (!seriesName.ContainsKey(info.Name)) seriesName.Add(info.Name, 0);                    
                }
                return seriesName;
            }
            public List<SerieInfo> SearchSeries(string title)
            {
                var series = _seriesList.FindAll(x => x.Name == title);
                return series;
            }
            public string Timer(string episode, string serie)
            {
                DateTime timeToWatch = _seriesList.Where(p => p.Name == serie && p.EpisodeName == episode).FirstOrDefault().AirTime;
                TimeSpan remaining = timeToWatch.Subtract(DateTime.Now);
                return string.Format("Days: {0:dd},  Hours:{1:hh}, Minutes:{1:mm} ", remaining, remaining, remaining);
                //return remaining.ToString("dd':'hh':'mm");
            }
        }
}
