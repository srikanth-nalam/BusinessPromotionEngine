using BusinessPromotionEngine.Services;
using Xunit;
using BusinessPromotionEngine.Models;

namespace BusinessPromotionEngine.Test.Services
{
    public class BusinessPromotionEngineManagerTest
    {
        private readonly IBusinessPromotionEngineManager _businessPromotionManager;


        public BusinessPromotionEngineManagerTest()
        {
            _businessPromotionManager = new BusinessPromotionEngineManager();
        }

        [Fact]
        public void GetFinalPriceForItems_TestForEmptyScenario()
        {
            #region Assign
            var expected = 0;
            ItemOrder itemOrder = new ItemOrder();
            #endregion Assign

            #region Act
            var actual = _businessPromotionManager.GetFinalPriceForItems(itemOrder);
            #endregion Act

            #region Assert
            Assert.Equal(actual, expected);
            #endregion Assert
        }

        [Fact]
        public void GetFinalPriceForItems_TestForScenario1()
        {
            #region Assign
            var expected = 100;
            ItemOrder itemOrder = new ItemOrder() { A = 1, B = 1, C = 1 };
            #endregion Assign

            #region Act
            var actual = _businessPromotionManager.GetFinalPriceForItems(itemOrder);
            #endregion Act

            #region Assert
            Assert.Equal(actual, expected);
            #endregion Assert
        }

        [Fact]
        public void GetFinalPriceForItems_TestForScenario2()
        {
            #region Assign
            var expected = 370;
            ItemOrder itemOrder = new ItemOrder() { A = 5, B = 5, C = 1 };
            #endregion Assign

            #region Act
            var actual = _businessPromotionManager.GetFinalPriceForItems(itemOrder);
            #endregion Act

            #region Assert
            Assert.Equal(actual, expected);
            #endregion Assert
        }

        [Fact]
        public void GetFinalPriceForItems_TestForScenario3()
        {
            #region Assign
            var expected = 280;
            ItemOrder itemOrder = new ItemOrder() { A = 3, B = 5, C = 1, D= 1 };
            #endregion Assign

            #region Act
            var actual = _businessPromotionManager.GetFinalPriceForItems(itemOrder);
            #endregion Act

            #region Assert
            Assert.Equal(actual, expected);
            #endregion Assert
        }

    }
}
