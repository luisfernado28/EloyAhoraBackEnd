﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EloyAhora.Entities
{
    public class EloyAhoraDatabaseSettings : IEloyAhoraDatabaseSettings
    {
        public string ProductsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IEloyAhoraDatabaseSettings
    {
        string ProductsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
