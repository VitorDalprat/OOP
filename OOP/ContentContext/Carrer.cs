using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ContentContext
{
    public class Carrer : Content
    {
        public Carrer(string title, string url)
            : base(title, url)  
        {
            Item = new List<CarrerItem>();
        }
        public IList<CarrerItem> Item { get; set; }

        public int TotalCurses
        {
            get
            {
                return Item.Count;  
            }
        }
        

    }


}
