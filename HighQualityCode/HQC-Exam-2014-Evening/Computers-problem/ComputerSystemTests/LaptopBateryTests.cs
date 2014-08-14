namespace ComputerSystemTests
{    
    // Two stylecop settings contradict each other -> one says use system namespaces before others, other says use alphabetical sorting!
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;    
    using ComputersSystem.Batteries;

    [TestClass]
    public class LaptopBateryTests
    {
        [TestMethod]
        public void TestInitialCreationBatteryPercentage()
        {
            var battery = new LaptopBattery();
            Assert.AreEqual(50, battery.PowerLeftPercentage);
        }

        [TestMethod]
        public void TestBatteryChargeWithMoreThanMaxPercentage()
        {
            var battery = new LaptopBattery();
            battery.Charge(100);
            Assert.AreEqual(100, battery.PowerLeftPercentage);
        }

        [TestMethod]
        public void TestBatteryChargeWithANegativeNumber()
        {
            var battery = new LaptopBattery();
            battery.Charge(-30);
            Assert.AreEqual(20, battery.PowerLeftPercentage);
        }

        [TestMethod]
        public void TestBatteryDeChargeWithMoreThanAvailablePower()
        {
            var battery = new LaptopBattery();
            battery.Charge(-100);
            Assert.AreEqual(0, battery.PowerLeftPercentage);
        }

        [TestMethod]
        public void TestBatteryChargeStraightScenario()
        {
            var battery = new LaptopBattery();
            battery.Charge(30);
            Assert.AreEqual(80, battery.PowerLeftPercentage);
        }
    }
}