using OOP.ContentContext.Enums;
using OOP.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ContentContext
{

    public class Lecture : Base
    {
        public int Order { get; set; }

        public string Title { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }

}
