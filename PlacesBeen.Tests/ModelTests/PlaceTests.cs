using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      // teardown method
      Place.ClearAll();
    }

    [TestMethod]
    // Test methods will go here
    public void PlaceConstructor_CreatesInstanceofPlace_Place()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetLocation_ReturnsLocation_String()
    {
      //Arrange
      string location = "Sydney";
      //Act
      Place newPlace = new Place(location);
      string result = newPlace.Location;
      //Assert
      Assert.AreEqual(location, result);
    }

    [TestMethod]
    public void GetAll_ReturnListOfAllInstancesOfPlace_List()
    {
      //Arrange
      string location = "Sydney";
      //Act
      Place newPlace = new Place(location);
      List<Place> newList = new List<Place> { newPlace };
      //Assert
      CollectionAssert.AreEqual(newList, Place.GetAll());
    }
  }
}