namespace TestProjectNunit
{
    [TestFixture]
    public class Tests
    {
        OurLib.Calc calc;
        [SetUp]
        
        public void Setup()
        {
            calc = new OurLib.Calc();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void AddTest()
        {
            int n1 = 2;
            int n2= 3;
            int result = 5;
            Assert.AreEqual(result,calc.Add(n1,n2));
        }
        [Test]
        public void AvgTest()
        {
            int n1 = 2;
            int n2 = 2;
            int result = 2;
            Assert.AreEqual(result, calc.Avg(n1, n2));
        }
        [Test]
        public void MultiTest()
        {
            int n1 = 2;
            int n2 = 3;
            int result = 6;
            Assert.AreEqual(result, calc.Multi(n1, n2));
        }
        [Test]
        public void DiffTest()
        {
            int n1 = 2;
            int n2 = 3;
            int result = -1;
            Assert.AreEqual(result, calc.Diff(n1, n2));
        }
    }
}