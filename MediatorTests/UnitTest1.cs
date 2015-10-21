using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediatorLib;

namespace MediatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ComputerSystem mediator = new ComputerSystem();
            Computer computer = new Computer(mediator);
            Keyboard keyboard = new Keyboard(mediator);
            Screen screen = new Screen(mediator);
        }
    }
}
