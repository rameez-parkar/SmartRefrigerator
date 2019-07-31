namespace SmartRefrigerator.App
{
    public class Notifier
    {
        private INotifier _notifier;

        public Notifier(INotifier notifier)
        {
            this._notifier = notifier;
        }

        public INotifier GetNotifier()
        {
            return _notifier;
        }

        public void SetMessageForInsufficiency(string insufficiencyMessage)
        {
            _notifier.SetMessageForInsufficiency(insufficiencyMessage);
        }
        public string GetMessageForInsufficiency()
        {
            return _notifier.GetMessageForInsufficiency();
        }
        public void SetMessageForOrderPlacement(string orderPlacementMessage)
        {
            _notifier.SetMessageForOrderPlacement(orderPlacementMessage);
        }
        public string GetMessageForOrderPlacement()
        {
            return _notifier.GetMessageForOrderPlacement();
        }
    }
}
