using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Tests
{
    [TestClass()]
    public class FacadeTests
    {
        string A = "SubSystem A";
        string B = "SubSystem B";
        string C = "SubSystem C";

        [TestMethod()]
        public void OperationABTest()
        {
            Facade facade = new Facade();
            string actual = facade.OperationAB();
            string expected = A + "\n" + B;
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod()]
        public void OperationBCTest()
        {
            Facade facade = new Facade();
            string actual = facade.OperationBC();
            string expected = B + "\n" + C;
            Assert.ReferenceEquals(actual, expected);
        }
    }

    [TestClass()]
    public class SubSystemATests
    {
        [TestMethod()]
        public void OperationATest()
        {
            SubSystemA subSystemA = new SubSystemA();
            string actual = subSystemA.OperationA();
            string expected = "SubSystem A";
            Assert.ReferenceEquals(actual, expected);
        }
    }
    
    [TestClass()]
    public class SubSystemBTests
    {
        [TestMethod()]
        public void OperationBTest()
        {
            SubSystemB subSystemB = new SubSystemB();
            string actual = subSystemB.OperationB();
            string expected = "SubSystem B";
            Assert.ReferenceEquals(actual, expected);
        }
    }
    [TestClass()]
    public class SubSystemCTests
    {
        [TestMethod()]
        public void OperationCTest()
        {
            SubSystemC subSystemC = new SubSystemC();
            string actual = subSystemC.OperationC();
            string expected = "SubSystem C";
            Assert.ReferenceEquals(actual, expected);
        }
    }
}