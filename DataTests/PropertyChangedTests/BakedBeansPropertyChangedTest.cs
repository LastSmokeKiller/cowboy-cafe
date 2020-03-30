using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTest
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var bean = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bean);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var bean = new BakedBeans();
            Assert.PropertyChanged(bean, "Size", () => { bean.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var bean = new BakedBeans();
            Assert.PropertyChanged(bean, "Calories", () => { bean.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var bean = new BakedBeans();
            Assert.PropertyChanged(bean, "Price", () => { bean.Size = Size.Large; });
        }
    }
}
