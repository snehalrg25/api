namespace Movieapi
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
            receipt r = new receipt(12233, "09/08/2000",678,"Sai","Darshan","India","9876543214", 875, "Widget", 12.99M, 7 );
            Assert.AreEqual(12233, r.receiptnumber);
            Console.WriteLine(r.totalcost());
        }
    }
}