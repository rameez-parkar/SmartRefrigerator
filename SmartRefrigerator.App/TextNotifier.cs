namespace SmartRefrigerator.App
{
    public class TextNotifier : INotifier
    {
        private string _insufficiencyMessage;
        private string _orderPlacementMessage;
        void INotifier.SetMessageForInsufficiency(string insufficiencyMessage)
        {
            _insufficiencyMessage = insufficiencyMessage;
        }
        string INotifier.GetMessageForInsufficiency()
        {
            return _insufficiencyMessage;
        }
        void INotifier.SetMessageForOrderPlacement(string orderPlacementMessage)
        {
            _orderPlacementMessage = orderPlacementMessage;
        }
        string INotifier.GetMessageForOrderPlacement()
        {
            return _orderPlacementMessage;
        }
    }
}
