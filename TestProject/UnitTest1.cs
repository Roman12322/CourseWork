using NUnit.Framework;

using Курсовая;
namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var test1 = new Calculations();
            var temp = test1.CalcSum("1", "1", "1", "1");
            Assert.AreEqual("2",temp);
        }
        [Test]
        public void Test2()
        {
            var test1 = new Calculations();
            var temp = test1.CalcSum("1", "0", "1", "1");
            Assert.AreEqual(" ", temp);
        }
        [Test]
        public void Test3()
        {
            var test1 = new Calculations();
            var temp = test1.CalcSum("", "", "1", "1");
            Assert.AreEqual(" ", temp);
        }
        [Test]
        public void Test4()
        {
            var test1 = new Calculations();
            var temp = test1.CalcTakeOff("10", "1", "5", "1");
            Assert.AreEqual("5", temp);
        }
        [Test]
        public void Test5()
        {
            var test1 = new Calculations();
            var temp = test1.CalcTakeOff("1", "0", "1", "1");
            Assert.AreEqual(" ", temp);
        }
        [Test]
        public void Test6()
        {
            var test1 = new Calculations();
            var temp = test1.CalcTakeOff("", "", "1", "1");
            Assert.AreEqual(" ", temp);
        }
        [Test]
        public void Test7()
        {

            var test1 = new Calculations();
            var temp = test1.CalcAnsDWN("", "");
            Assert.AreEqual(" ", temp);
        }
        [Test]
        public void Test8()
        {
            var test1 = new Calculations();
            var temp = test1.CalcAnsDWN("5", "6");
            Assert.AreEqual("30", temp);
        }
    }
}