using SmartRefrigerator.App;
using System;
using System.Collections.Generic;
using Xunit;

namespace SmartRefrigerator.Test
{
    public class SmartRefrigeratorTests
    {
        [Fact]
        public void AddVegetableToEmptyTrayTest()
        {
            var refrigerator = new Refrigerator();
            var tomato = new Tomato();
            refrigerator.AddVegetable(tomato, 4);

            var expected = new List<KeyValuePair<Vegetable, int>>(){new KeyValuePair<Vegetable, int>(tomato, 4)};
            var actual = refrigerator.GetVegetableQuantity();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TakeOutVegetableFromTrayTest()
        {
            var refrigerator = new Refrigerator();
            var tomato = new Tomato();
            refrigerator.AddVegetable(tomato, 5);
            //refrigerator.SetMinimumVegetableQuantity(new Tomato(), 2);
            refrigerator.TakeOutVegetable(tomato, 3);

            var expected = new List<KeyValuePair<Vegetable, int>>() { new KeyValuePair<Vegetable, int>(tomato, 2) };
            var actual = refrigerator.GetVegetableQuantity();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TrackQuantityTest()
        {
            var refrigerator = new Refrigerator();
            var tomato = new Tomato();
            refrigerator.AddVegetable(tomato, 5);
            refrigerator.SetMinimumVegetableQuantity(tomato, 7);

            var expected = new List<KeyValuePair<Vegetable, int>>() { new KeyValuePair<Vegetable, int>(tomato, 5) };
            var actual = refrigerator.TrackQuantity();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PlaceOrderTest()
        {
            var refrigerator = new Refrigerator();
            var tracker = new VegetableTracker();
            var tomato = new Tomato();
            refrigerator.AddVegetable(tomato, 5);
            refrigerator.SetMinimumVegetableQuantity(tomato, 4);
            refrigerator.SetMaximumRefillLimit(tomato, 10);
            tracker.PlaceOrder(refrigerator);

            var expected = new List<KeyValuePair<Vegetable, int>>() { new KeyValuePair<Vegetable, int>(tomato, 5) };
            var actual = refrigerator.GetVegetableQuantity();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmailNotificationTest()
        {
            var refrigerator = new Refrigerator();
            var email = refrigerator.SetNotificationChannel("email");

            email.SetMessageForInsufficiency("Vegetable insufficient...");

            var expected = "Vegetable insufficient...";
            var actual = email.GetMessageForInsufficiency();

            Assert.Equal(expected, actual);
        }
    }
}
