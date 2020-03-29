using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTest
    {
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var texas = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texas);
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Bun", () => { texas.Bun = false; });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Bun = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Pickle", () => { texas.Pickle = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Pickle = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Ketchup", () => { texas.Ketchup = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Ketchup = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Mustard", () => { texas.Mustard = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Mustard = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Cheese", () => { texas.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Cheese = false; });
        }
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Lettuce", () => { texas.Lettuce = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Lettuce = false; });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Egg", () => { texas.Egg = false; });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Egg = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Mayo", () => { texas.Mayo = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Mayo = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Tomato", () => { texas.Tomato = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Tomato = false; });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Bacon", () => { texas.Bacon = false; });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () => { texas.Bacon = false; });
        }
    }
}
