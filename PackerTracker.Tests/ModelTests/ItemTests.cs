using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      // teardown method
      Item.ClearAll();
    }

    [TestMethod]
    // Test methods will go here
    public void ItemConstructor_CreatesInstanceofItem_Item()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "backpack";
      //Act
      Item newItem = new Item(description);
      string result = newItem.Description;
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnListOfAllInstancesOfItem_List()
    {
      //Arrange
      string description = "backpack";
      //Act
      Item newItem = new Item(description);
      List<Item> newList = new List<Item> { newItem };
      //Assert
      CollectionAssert.AreEqual(newList, Item.GetAll());
    }
  }
}