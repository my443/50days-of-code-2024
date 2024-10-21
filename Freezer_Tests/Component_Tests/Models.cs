using System.ComponentModel;
using freezer_console;

namespace Freezer_Tests.Component_Tests
{
    [TestClass]
    public class Models
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            freezer_console.Models.Container container = new freezer_console.Models.Container();
        }
        [TestMethod]
        public void TestThatClassExists()
        {
            freezer_console.Models.Container container = new freezer_console.Models.Container();
            Assert.IsInstanceOfType(container, typeof(freezer_console.Models.Container));
        }

   


    }
}
