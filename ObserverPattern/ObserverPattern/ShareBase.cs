using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class ShareBase
    {
        protected string _name;
        protected double _price;

        protected List<IShareNotifier> _observerList = new List<IShareNotifier>(); 

        protected ShareBase(string name,double price)
        {
            _name = name;
            _price = price;
        }

        public string Name
        {
            get { return _name; }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                foreach (var observer in _observerList)
                {
                    observer.Notify(this);
                }
            }
        }

        public void Subscribe(IShareNotifier observer)
        {
            _observerList.Add(observer);
        }

        public void UnSubscribe(IShareNotifier observer)
        {
            _observerList.Remove(observer);
        }
    }
}