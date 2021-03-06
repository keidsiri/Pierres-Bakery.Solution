using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
      public void Pastry_CreateNewInstanceOfPastry_Pastry()
      {
        Pastry newPastry = new Pastry(1);
        Assert.AreEqual(typeof(Pastry) , newPastry.GetType());
      }
    
    [TestMethod]
      public void Pastry_GetAmountOfPastry_Int()
      {
        int pastryAmount = 3;
        Pastry newPastry = new Pastry(pastryAmount);
        int amount = newPastry.PastryAmount;
        Assert.AreEqual(pastryAmount, amount);
      }

    [TestMethod]
      public void Pastry_SetChangeAmountOfPastry_Int()
      {
        int pastryAmount = 3;
        Pastry newPastry = new Pastry(pastryAmount);
        int pastryAmountChange = 10;
        newPastry.PastryAmount = pastryAmountChange;
        int amount = pastryAmountChange;
        Assert.AreEqual(pastryAmountChange, amount);
      }

    [TestMethod]
      public void Pastry_GetPastryPrice_Int()
      {
        int pastryPrice = 2;
        Pastry newpastry = new Pastry(pastryPrice);
        int price = newpastry.PastryPrice;
        Assert.AreEqual(pastryPrice, price);
      }

    [TestMethod]
      public void Pastry_ReturnCostOfPastry_Int()
      {
        int PastryAmount = 1;
        int PastryPrice  = 2;
        Pastry newPastry = new Pastry(PastryAmount);
        int newOrder = newPastry.PastryCost();
        Assert.AreEqual(PastryPrice, newOrder);
      }

    [TestMethod]
      public void Pastry_ReturnCostOfSixPastry_Int()
      {
        int PastryAmount = 6;
        int PastryPrice  = 10;
        Pastry newPastry = new Pastry(PastryAmount);
        int newOrder = newPastry.PastryCost();
        Assert.AreEqual(PastryPrice, newOrder);
      }

    [TestMethod]
      public void Pastry_ReturnCostOf5Pastry_Int()
      {
        int PastryAmount = 5;
        int PastryPrice  = 9;
        Pastry newPastry = new Pastry(PastryAmount);
        int newOrder = newPastry.PastryCost();
        Assert.AreEqual(PastryPrice, newOrder);
      }
  }
}