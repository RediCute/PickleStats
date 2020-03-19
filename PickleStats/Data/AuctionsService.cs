using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PickleStats.Data
{
    public class AuctionsService
    {
        public Task<Auctions> GetAuctionsAsync()
        {
            var json = File.ReadAllText("C:/Users/Darell/source/repos/PickleStats/PickleStats/bin/Debug/netcoreapp3.1/Resources/batch_0.json");
            return null;
        }

    }
}
