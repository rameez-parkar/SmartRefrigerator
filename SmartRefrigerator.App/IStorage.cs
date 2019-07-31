namespace SmartRefrigerator.App
{
    public interface IStorage
    {
        void SetVegetableMinimumQuantity(Vegetable vegetable, int quantity);
        int GetVegetableMinimumQuantity(Vegetable vegetable);
        int GetVegetableRefillLimit(Vegetable vegetable);
        void SetVegetableRefillLimit(Vegetable vegetable, int quantity);
    }
}
