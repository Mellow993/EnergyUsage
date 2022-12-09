using EnergyUsage.BusinessLogic;

namespace TestEnergyUsage
{
    public class BL_Costs_UnitTest
    {
        [Fact]
        public void Costs_AddOneToPrice()
        {
            // Arrange
            Costs costs = new Costs();
            costs.Price = 1;
            var result = costs.AddOneToPrice();

            // Assert
            Assert.Equal(2, result);

        }
    }
}