using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using APIConsume.Models;



namespace APIConsume.Services
{
    
    public class NseService
    {
        private readonly IMongoCollection<Nse> _nse;
        private readonly IMongoCollection<SMAT> _sma;
        public NseService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("Watchlist"));
            IMongoDatabase database = client.GetDatabase("Watchlist");
            _nse = database.GetCollection<Nse>("sma");
        }

        public List<Nse> Get()
        {
            return _nse.Find(SMAT => true).ToList();
        }

        public Nse Get(string id)
        {
            return _nse.Find(ne => ne.Id == id).FirstOrDefault();
        }

        public Nse Create(Nse nse)
        {
            _nse.InsertOne(nse);
            return nse;
        }

        public void Update(string id, Nse nseIn)
        {
            _nse.ReplaceOne(ne => ne.Id == id, nseIn);
        }

        public void Remove(Nse nseIn)
        {
            _nse.DeleteOne(ne => ne.Id == nseIn.Id);
        }

        public void Remove(string id)
        {
            _nse.DeleteOne(ne => ne.Id == id);
        }

        /*public List<SMAT> SearchSymbol(string SearchSYMBOL)
        {
            return _sma.Find(SMAT => SMAT.SYMBOL == SearchSYMBOL).ToList();
        }*/
    }
}

