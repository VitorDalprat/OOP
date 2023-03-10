using OOP.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Subscription
{
    public class Student : Base
    {

        public Student()
        {
            Subscriptions= new List<Subscription>();
        }
        public User User { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification.Notification("Premium", "O Aluno já tem uma assinatura ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}
