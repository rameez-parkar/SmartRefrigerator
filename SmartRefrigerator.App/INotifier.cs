namespace SmartRefrigerator.App
{
    public interface INotifier
    {
        void SetMessageForInsufficiency(string insufficiencyMessage);
        string GetMessageForInsufficiency();
        void SetMessageForOrderPlacement(string orderPlacementMessage);
        string GetMessageForOrderPlacement();
    }
}
