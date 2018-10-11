using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(3, 3)]
        public void CustomerFeedsMoney_BalanceUpdated(int expected, int input)
        {
            // Arrange
            VendingMachine vm = new VendingMachine();

            // Act
            decimal output = vm.FeedMoney(input);

            //Assert
            Assert.AreEqual(expected, output);
        }
    }
}
