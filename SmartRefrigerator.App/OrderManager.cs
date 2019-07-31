using System.Collections.Generic;

namespace SmartRefrigerator.App
{
    public class OrderManager
    {
        public void PlaceOrderForInsufficientItems(Refrigerator refrigerator)
        {
            var insufficientVegetables = refrigerator.TrackQuantity();

            foreach (var item in insufficientVegetables)
            {
                var maximumRefillLimit = refrigerator.GetMaximumRefillLimit(item.Key);
                var quantity = maximumRefillLimit - item.Value;
                refrigerator.AddVegetable(item.Key, quantity);
            }
        }
    }
}
