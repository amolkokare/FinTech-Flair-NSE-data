﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsume.Models
{
      public class NseDatabaseSetting : INseDatabaseSetting
        {
            public string watchlistCollectionName { get; set; }
            public string SMACollectionName { get; set; }
            public string ConnectionString { get; set; }
            public string DatabaseName { get; set; }
        }
        public interface INseDatabaseSetting
        {
            string watchlistCollectionName { get; set; }
            string SMACollectionName { get; set; }
            string ConnectionString { get; set; }
            string DatabaseName { get; set; }
        }

    }

