using System.Collections.Generic;

namespace SmartRefrigerator.App
{
    public class InMemoryStorage : IStorage
    {
        private Dictionary<Vegetable, int> _vegetableQuantities = new Dictionary<Vegetable, int>();
        private Dictionary<Vegetable, int> _refillLimits = new Dictionary<Vegetable, int>();
        public int GetVegetableMinimumQuantity(Vegetable vegetable)
        {
            if (_vegetableQuantities.ContainsKey(vegetable))
            {
                return _vegetableQuantities[vegetable];
            }

            throw new VegetableNotFoundException();
        }

        public void SetVegetableMinimumQuantity(Vegetable vegetable, int quantity)
        {
            if (_vegetableQuantities.ContainsKey(vegetable))
            {
                _vegetableQuantities[vegetable] = quantity;
            }
            else
            {
                _vegetableQuantities.Add(vegetable, quantity);
            }
        }

        public int GetVegetableRefillLimit(Vegetable vegetable)
        {
            if (_refillLimits.ContainsKey(vegetable))
            {
                return _refillLimits[vegetable];
            }

            throw new VegetableNotFoundException();
        }

        public void SetVegetableRefillLimit(Vegetable vegetable, int quantity)
        {
            if(_refillLimits.ContainsKey(vegetable))
            {
                _refillLimits[vegetable] = quantity;
            }
            else
            {
                _refillLimits.Add(vegetable, quantity);
            }
        }
    }
}
