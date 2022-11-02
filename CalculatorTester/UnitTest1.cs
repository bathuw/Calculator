using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        [TestInitialize]
        public void SetUp()
        {
            c = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(c.Execute("+"), 15);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(c.Execute("-"), 5);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(c.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(c.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c=new Calculation(10, 0);
            c.Execute("/");
        }
        //Liên kết Testdata với project
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataPower.csv", "TestDataPower#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestPower()
        {
            int n = int.Parse(TestContext.DataRow[1].ToString());
            double x = double.Parse(TestContext.DataRow[0].ToString());
            double expected = double.Parse(TestContext.DataRow[2].ToString());
            double actual = Calculation.Power(x, n);
            Assert.AreEqual(expected,actual);


        }
    }
}
