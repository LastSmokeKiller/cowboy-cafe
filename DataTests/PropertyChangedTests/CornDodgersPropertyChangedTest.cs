using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTest
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () => { corn.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Calories", () => { corn.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Price", () => { corn.Size = Size.Large; });
        }
    }
}
