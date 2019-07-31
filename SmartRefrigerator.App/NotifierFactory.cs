namespace SmartRefrigerator.App
{
    public class NotifierFactory
    {
        public INotifier GetNotifier(string notifierType)
        {
            switch(notifierType.ToLowerInvariant())
            {
                case "email":
                    return new EmailNotifier();
                default:
                    throw new VegetableNotFoundException();
            }
        }
    }
}
