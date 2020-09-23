using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOgame
{
    class Resource : IDBEntity
    {
        private string Name { get; set; }
        private int? LastQuantity { get; set; }
        private DateTime LastUpdate { get; set; }
    }
}
