using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        List<Item> itemsList;
        Item item;
        Item item2;

        [TestInitialize]
        public void BeforeTest()
        {
            itemsList = new List<Item>();
            item = new Item("A1", "Potato Crisps", 3.05m, "Chip");
            item2 = new Item("B1", "Moonpie", 1.80m, "Candy");
            itemsList.Add(item);
            itemsList.Add(item2);
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(3, 3)]
        [DataRow(null, -1)]
        [DataRow(10000, 10000)]
        public void CustomerFeedsMoney_BalanceUpdated(int expected, int input)
        {
            // Arrange
            VendingMachine vm = new VendingMachine(null);

            // Act
            decimal output = vm.FeedMoney(input);

            //Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void CustomerUsesSlotID_ToGetItem()
        {
            VendingMachine vm = new VendingMachine(itemsList);

            Item output = vm.SelectProduct("A1");
            Item output2 = vm.SelectProduct("B1");
            Item output3 = vm.SelectProduct("G2");
            Item output4 = vm.SelectProduct("Chris");
            Item output5 = vm.SelectProduct("11");
 
            Assert.AreEqual("Potato Crisps", output.Name);
            Assert.AreEqual("Moonpie", output2.Name);
            Assert.AreEqual(null, output3);
            Assert.AreEqual(null, output4);
            Assert.AreEqual(null, output5);
        }

        [TestMethod]
        public void WhenFinishedTransaction_ChangeIsDispensed() 
        {
            VendingMachine vm = new VendingMachine(itemsList);

            decimal result = vm.DispenseChange();

            Assert.AreEqual(0, result);
        }
    }
}
