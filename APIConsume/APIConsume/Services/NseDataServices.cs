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


        public List<SMAT> Search(string SearchTimeStamp)
        {
            return _sma.Find(SMAT => SMAT.TIMESTAMP == SearchTimeStamp).ToList();
        }

        public List<SMAT> SearchSymbol(string SearchSYMBOL)
        {
            return _sma.Find(SMAT => SMAT.SYMBOL == SearchSYMBOL).ToList();
        }

    }
}

    

