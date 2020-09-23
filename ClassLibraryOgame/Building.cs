using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOgame
{
    class Building : IDBEntity
    {
        private string Name { get; set; }
        private int? Level { get; set; }
        public int? CellNb()
        {
            return null;
        }
        public List<Resource> TotalCost()
        {
            return null;
        }
        public List<Resource> NextCost()
        {
            return null;
        }
    }
}
