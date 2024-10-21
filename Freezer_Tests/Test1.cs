namespace Freezer_Tests
{
    [TestClass]
    public sealed class Test1
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            // This method is called once for the test class, before any tests of the class are run.
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }
    }
}
