﻿using CurrencyTrader.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader.AdoNet
{
    public class AsynchTradeStorage : ITradeStorage
    {
        private readonly ILogger logger;
        private ITradeStorage SynchTradeStorage;

        public AsynchTradeStorage(ILogger logger)
        {
            this.logger = logger;
            SynchTradeStorage = new AdoNetTradeStorage(logger);
        }

        public void Persist(IEnumerable<TradeRecord> trades)
        {
            logger.LogInfo("Starting trade storage - synch");
            SynchTradeStorage.Persist(trades);
            logger.LogInfo("Finished trade storage - synch");
        }
    }
}
