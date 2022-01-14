using NUnit.Framework;

using Курсовая;
namespace TestsForCouresProject
{
    public class Tests
    {
        [Test]
        public void FirstTest()
        {
            var calcsum = new Calculations();
            var actualAns = calcsum.answerSum("1", "1", "4", "1");
            var neededanswer = 5.0;
            Assert.AreEqual(neededanswer,actualAns);
        }
        [Test]
        public void SecondTest()
        {
            var calctakeoff = new Calculations();
            var actualAns = calctakeoff.answerTakeOff("1", "1", "4", "1");
            var neededanswer = -3.0;
            Assert.AreEqual(neededanswer, actualAns);
        }
        [Test]
        public void TestExpetions()
        {
            var ex_ = new Calculations();
            Assert.AreEqual(" ",ex_.CalcSum("0", "0", "0", "0"));
        }
    }
}