using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp;
using ewmsCsharp.Classes;

namespace ewmsCsharpTest
{
    [TestClass]
    public class AddingTest
    {

        
        public AddingTest() {
  
        }



        

        [TestMethod]
        [DataRow("Item Test1111")]
        //[DataRow(1212121)]
        public void AddItemToListTest(string expected_itemName) {

            // Arrange
            //Act
            List.Add.Item(new("11111", "Item Test1111"));
            Item actual_GetAddedItem = List.Items.Find(item => item.Id == "11111");

            //Assert
            //Assert.AreEqual(expected, actual);

            Assert.AreEqual(actual_GetAddedItem.Name, expected_itemName);
        }



        

    }

}
