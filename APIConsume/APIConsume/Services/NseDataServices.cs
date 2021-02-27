using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using APIConsume.Models;

namespace APIConsume.Services
{
    public class NseDataServices
    {
        private readonly IMongoCollection<SMAT> _sma;
       
        public NseDataServices(INseDatabaseSetting settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _sma = database.GetCollection<SMAT>(settings.SMACollectionName);
        }


        

        // It gives whole data
        public List<SMAT> Get()
        {
            return _sma.Find(SMAT=> true).ToList();
        }

        // It gives symbol that we want to search
        public List<SMAT> Search(string SearchSYMBOL)
        {
           return _sma.Find(SMAT => SMAT.SYMBOL == SearchSYMBOL).ToList();
        }

        // It returns Max date
        public DateTime getMaxDate()
        {

            // return SM.Find(Stock => Stock.TIMESTAMP==SearchTodayDate).ToList();
            var cd = Get();

            var date = Convert.ToDateTime(cd.OrderByDescending(d => d.TIMESTAMP).Select(s => s.TIMESTAMP).First());// Convert.ToDateTime("2021-02-23T05:13:00.608Z");//max timestamp
            return date;

        }

        

        // It gives Max date with Away_52weekhigh,geater close and max Volume
        public List<SMAT> searchaway52weekhigh(string scannerName)
        {
            DateTime maxDate = getMaxDate();
            List<SMAT> slist = new List<SMAT>();

            
                var cd = Get().ToList();
                string g = maxDate.ToString();
                var f = g.Split(" ");
                foreach (var item in cd)
                {
                    var a = 0;
                    var close = item.CLOSE;
                    var Highweek = item.Away_From_52WeekHigh;
                    var Vol = item.Volume;
                    string times = item.TIMESTAMP.ToString();
                    

                    if (Vol> 876213 && close > 500 && times.Contains(f[0]) && Highweek.Equals(a))
                    {
                        slist.Add(item);
                    }
                  
                }

                return slist;
        }

        // It gives Max date with Away_52weeklow,geater close and max Volume
        public List<SMAT> searchaway52weeklow(string scannerName)
        {
            DateTime maxDate = getMaxDate();
            List<SMAT> slist = new List<SMAT>();


            var cd = Get().ToList();
            string g = maxDate.ToString();
            var f = g.Split(" ");
            foreach (var item in cd)
            {
                var a = 0;
                var close = item.CLOSE;
                var LowWeek = item.Away_From_52WeekLow;
                var Vol = item.Volume;
                string times = item.TIMESTAMP.ToString();


                if (Vol > 876213 && close > 500 && times.Contains(f[0]) && LowWeek.Equals(a))
                {
                    slist.Add(item);
                }

            }

            return slist;
        }

        // It gives Max date with greater Relatie_volume,geater close and max Volume
        public List<SMAT> Rel_Momentum(string scannerName)
        {
            DateTime maxDate = getMaxDate();
            List<SMAT> slist = new List<SMAT>();


            var cd = Get().ToList();
            string g = maxDate.ToString();
            var f = g.Split(" ");
            foreach (var item in cd)
            {
                
                var close = item.CLOSE;
                var RelVol = item.Relative_Volume;
                var Vol = item.Volume;
                string times = item.TIMESTAMP.ToString();


                if (RelVol > 0.999735239 && Vol > 876213 && close > 500 && times.Contains(f[0]))
                {
                    slist.Add(item);
                }

            }

            return slist;
        }

    }
}



