using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class ItemTest
    {
        List<Item> itemsList;
        Item chip;
        Item candy;
        Item drink;
        Item gum;

        [TestInitialize]
        public void beforeTest()
        {
            itemsList = new List<Item>();
            chip = new Item("A1", "Potato Crisps", 3.05m, "Chip");
            candy = new Item("B1", "Moonpie", 1.80m, "Candy");
            drink = new Item("C1", "Cola", 1.25m, "Drink");
            gum = new Item("D1", "U-Chews", 0.85m, "Gum");
            itemsList.Add(chip);
            itemsList.Add(candy);
            itemsList.Add(drink);
            itemsList.Add(gum);
        }
        [TestMethod]
        public void GetSoundString_ByItemType()
        {
            //Arrange
            Item chip = new Item("A1", "Potato Crisps", 3.05m, "Chip");
            Item candy = new Item("B1", "Moonpie", 1.80m, "Candy");
            Item drink = new Item("C1", "Cola", 1.25m, "Drink");
            Item gum = new Item("D1", "U-Chews", 0.85m, "Gum");

            //Act
            string output = chip.MakeSound();
            string output2 = candy.MakeSound();
            string output3 = drink.MakeSound();
            string output4 = gum.MakeSound();


            //Assert
            Assert.AreEqual("Crunch Crunch, Yum!", output);
            Assert.AreEqual("Munch Munch, Yum!", output2);
            Assert.AreEqual("Glug Glug, Yum!", output3);
            Assert.AreEqual("Chew Chew, Yum!", output4);
        }
    }
}
