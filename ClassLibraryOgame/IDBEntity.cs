using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOgame
{
    public abstract class IDBEntity
    {
        public virtual long? Id { get; set; }
    }
}
