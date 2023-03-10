using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Shared;

namespace OOP.ContentContext
{
    public class CarrerItem : Base
    {
        public IList<String> Notification { get; set; }
        public CarrerItem(int order, string title, string description, Curse curse)
        {
            if (curse == null)
            {
                AddNotification(new OOP.Notification.Notification("Curse", "Curso Inválido "));
            }

            Order = order;
            Title = title;
            Description = description;
            Curse = curse;
        }

        public int Order { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Curse Curse { get; set; }

    }
}
