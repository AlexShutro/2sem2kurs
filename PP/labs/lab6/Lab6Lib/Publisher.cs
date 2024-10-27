using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Lib
{
    public class Publisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>(); 
        private string eventName; 

        public Publisher(string eventName)
        {
            this.eventName = eventName;
        }

        public void subscribe(ISubscriber sub)
        {
            subscribers.Add(sub); 
        }

        public bool unsubscribe(ISubscriber sub)
        {
            return subscribers.Remove(sub); 
        }

        public int nonify()
        {
            int count = 0; 
            foreach (ISubscriber sub in subscribers) 
            {
                sub.update(eventName); 
                count++; 
            }
            return count; 
        }


    }

}