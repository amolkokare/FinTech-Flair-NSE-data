﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using WatchList.Models;

namespace WatchList.Services
{
    public class NseService
    {

        private readonly IMongoCollection<Nse> _nse;

        public NseService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("Watchlist"));
            IMongoDatabase database = client.GetDatabase("Watchlist");
            _nse = database.GetCollection<Nse>("nse");
        }

        public List<Nse> Get()
        {
            return _nse.Find(ne => true).ToList();
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
    }
}
