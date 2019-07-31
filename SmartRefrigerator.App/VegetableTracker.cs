using System.Collections.Generic;

namespace SmartRefrigerator.App
{
    public class VegetableTracker
    {
        private OrderManager _order = new OrderManager();
        public List<KeyValuePair<Vegetable, int>> GetInsufficientVegetableQuantity(VegetableTray vegetableTray, ConfigurationManager configurationManager)
        {
            var vegetableQuantity = vegetableTray.GetVegetableQuantity();
            var insufficientVegetables = new List<KeyValuePair<Vegetable, int>>();

            foreach (var item in vegetableQuantity)
            {
                if(item.Value <= configurationManager.GetMinimumQuantity(item.Key))
                {
                    insufficientVegetables.Add(item);
                }
            }
            return insufficientVegetables;
        }

        public void PlaceOrder(Refrigerator refrigerator)
        {
            _order.PlaceOrderForInsufficientItems(refrigerator);
        }
    }
}
