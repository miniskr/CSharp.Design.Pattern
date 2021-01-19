namespace Design.Pattern.ObserverPattern
{
    public delegate void NotifyEventHandler(object sender);

    public class SubWithEvent
    {
        public event NotifyEventHandler NotifyEvent;

        private double _money;

        public SubWithEvent()
        {
        }

        public double Money
        {
            get => this._money;
            set
            {
                this._money = value;
                OnNotifyChange();
            }
        }

        public void WithDraw()
        {
            OnNotifyChange();
        }

        public void OnNotifyChange()
        {
            NotifyEvent?.Invoke(this);
        }

    }
}
