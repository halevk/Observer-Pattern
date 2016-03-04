namespace ObserverPattern
{
    public class Invester : IShareNotifier
    {
        private string _name;

        public Invester(string name)
        {
            _name = name;
        }

        public void Notify(ShareBase share)
        {
            
        }
    }
}