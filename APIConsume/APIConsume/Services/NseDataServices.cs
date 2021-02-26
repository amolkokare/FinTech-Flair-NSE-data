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
        

        /*public List<SMAT> Get()
        {
            List<SMAT> smat;
            smat = _sma.Find(sma => true).ToList();
            return smat;
        }*/


        /*public SMAT Get(string id) =>
           _sma.Find<SMAT>(sma => sma.Id == id).FirstOrDefault();*/


        public List<SMAT> Get()
        {
            return _sma.Find(SMAT=> true).ToList();
        }

        public List<SMAT> Search(string SearchSYMBOL)
        {
           return _sma.Find(SMAT => SMAT.SYMBOL == SearchSYMBOL).ToList();
        }

        /*public List<SMAT> SearchTime(string SearchTimeStamp)
        {
            return _sma.Find(SMAT => SMAT.TIMESTAMP == SearchTimeStamp).ToList();
        }*/


        public List<SMAT> searchdate(string scannerName)
        {
            DateTime maxDate = getMaxDate();
            List<SMAT> slist = new List<SMAT>();

            
                var cd = Get().ToList();
                string g = maxDate.ToString();
                var f = g.Split(" ");
                foreach (var item in cd)
                {
                var a = 0;
                var c = item.CLOSE;
                var b = item.Away_From_52WeekHigh;
                    string d = item.TIMESTAMP.ToString();

                    if (c > 1300 && d.Contains(f[0]) && b.Equals(a))
                    {
                        slist.Add(item);
                    }
                  
                }

                return slist;
            
            
           

        }
        public DateTime getMaxDate()
        {

            // return SM.Find(Stock => Stock.TIMESTAMP==SearchTodayDate).ToList();
            var cd = Get();

            var date = Convert.ToDateTime(cd.OrderByDescending(d => d.TIMESTAMP).Select(s => s.TIMESTAMP).First());// Convert.ToDateTime("2021-02-23T05:13:00.608Z");//max timestamp
            return date;

        }

        public List<SMAT> Week52(double searchhigh)
        {
           


            var y = _sma.Find(g => g.Away_From_52WeekHigh == searchhigh ).ToList();

            return y;
        }


    }
}



