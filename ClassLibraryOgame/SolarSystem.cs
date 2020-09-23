using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOgame
{
    public class SolarSystem : IDBEntity
    {
        public string Name { get; set; }
        public List<Planet> Planets { get; set; }
    }
}
