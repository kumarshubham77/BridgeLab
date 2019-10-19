using DesignPattern.Singleton.BehavioralDesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.BehavioralDesignPattern.Subject
{
    public class YoutubeChannel
    {
        private IList<ISubscriber> subscribers = new List<ISubscriber>();
        public void Subscribe(ISubscriber s)
        {
            subscribers.Add(s);
        }
       
        public void Unsubscribe(ISubscriber s)
        {
            subscribers.Remove(s);
        }

        public void NotifySubscribers()
        {
            foreach(ISubscriber s in subscribers)
            {
                s.Notify();
            }
        }
    }
}
