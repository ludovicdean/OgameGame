using System.Collections.Generic;

namespace ClassLibraryOgame
{
    public class Planet : IDBEntity
    {
        private string Name { get; set; }
        private int? CaseNb { get; set; }

        private List<Resource> Resources { get; set; }
    }
}