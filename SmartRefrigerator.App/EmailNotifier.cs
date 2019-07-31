namespace SmartRefrigerator.App
{
    public class EmailNotifier : IEmail
    {
        private string _insufficiencyMessage;
        private string _orderPlacementMessage;
        private string _subjectMessage;
        
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

        void IEmail.SetSubject(string subjectMessage)
        {
            _subjectMessage = subjectMessage;
        }

        string IEmail.GetSubject()
        {
            return _subjectMessage;
        }
    }
}
