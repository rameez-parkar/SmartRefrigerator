using System.Collections.Generic;

namespace SmartRefrigerator.App
{
    public class Refrigerator
    {
        private VegetableTray _vegetableTray = new VegetableTray();

        private ConfigurationManager _configurationManager = new ConfigurationManager(new InMemoryStorage());

        private VegetableTracker _vegetableTracker = new VegetableTracker();

        private NotifierFactory _notifierFactory = new NotifierFactory();

        private Notifier _notifier;

        public void AddVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.Add(vegetable, quantity);
        }

        public void TakeOutVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.TakeOut(vegetable, quantity);
        }

        public List<KeyValuePair<Vegetable, int>> GetVegetableQuantity()
        {
            return _vegetableTray.GetVegetableQuantity();
        }

        public void SetMinimumVegetableQuantity(Vegetable vegetable, int quantity)
        {
            _configurationManager.SetMinimumQuantity(vegetable, quantity);
        }

        public void SetMaximumRefillLimit(Vegetable vegetable, int quantity)
        {
            _configurationManager.SetMaximumRefillLimit(vegetable, quantity);
        }

        public List<KeyValuePair<Vegetable, int>> TrackQuantity()
        {
            var insufficientVegetables = _vegetableTracker.GetInsufficientVegetableQuantity(_vegetableTray, _configurationManager);
            return insufficientVegetables;
        }

        public int GetMaximumRefillLimit(Vegetable vegetable)
        {
            return _configurationManager.GetMaximumRefillLimit(vegetable);
        }

        public INotifier SetNotificationChannel(string notifierType)
        {
            _notifier = new Notifier(_notifierFactory.GetNotifier(notifierType));
            return _notifier.GetNotifier();
        }
    }
}
