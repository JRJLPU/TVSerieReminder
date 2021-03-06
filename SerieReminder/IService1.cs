﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SerieDatabase;

namespace SerieReminder
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Dictionary<string, int> GetAllSeries();

        [OperationContract]
        List<SerieInfo> SearchSeries(string title);

        [OperationContract]
        string Timer(string episode, string serie);
    }
}
