using CurrencyTrader.Contracts;
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

        /// <summary>
        /// Decorator object that creates an AdoNetTradeStorage object
        /// </summary>
        /// <param name="logger">Logger to output log messages to</param>
        public AsynchTradeStorage(ILogger logger)
        {
            this.logger = logger;
            SynchTradeStorage = new AdoNetTradeStorage(logger);
        }

        /// <summary>
        /// Runs the persist method of the AdoNetTradeStorage object, but does it in a seperate thread/task
        /// </summary>
        /// <param name="trades">Trades to persist to the database</param>
        public void Persist(IEnumerable<TradeRecord> trades)
        {
            logger.LogInfo("Starting trade storage - synch");
            //Persists in a second thread
            Task.Run(() => SynchTradeStorage.Persist(trades));
            logger.LogInfo("Finished trade storage - synch");
        }
    }
}
