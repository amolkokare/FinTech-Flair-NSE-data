using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using NseDataApi.Models;

namespace NseDataApi.Services
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
        public List<SMAT> Get() =>
            _sma.Find(sma => true).ToList();

        public SMAT Get(string id) =>
            _sma.Find<SMAT>(sma => sma.Id == id).FirstOrDefault();
    }
}
