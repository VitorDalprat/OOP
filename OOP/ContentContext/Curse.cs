using OOP.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ContentContext
{
    public class Curse : Content
    {
        public Curse(string title, string url)
            :base (title, url)
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; }

        public IList<Module> Modules { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}
