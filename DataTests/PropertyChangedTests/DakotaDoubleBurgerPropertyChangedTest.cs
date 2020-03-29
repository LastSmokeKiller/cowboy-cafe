﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangedTest
    {
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakota);
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Bun", () => { dakota.Bun = false; });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Bun = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Ketchup", () => { dakota.Ketchup = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Ketchup = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mustard", () => { dakota.Mustard = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Mustard = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Pickle", () => { dakota.Pickle = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Pickle = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Cheese", () => { dakota.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Cheese = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Tomato", () => { dakota.Tomato = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Tomato = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Lettuce", () => { dakota.Lettuce = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Lettuce = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mayo", () => { dakota.Mayo = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Mayo = false; });
        }
    }
}
