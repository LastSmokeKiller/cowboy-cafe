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
    }
}
