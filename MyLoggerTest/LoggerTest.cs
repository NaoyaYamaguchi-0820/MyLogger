using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyLogger;

namespace MyLoggerTest
{
    [TestClass]
    public class LoggerTest
    {
        [TestMethod]
        public void ViewTest()
        {
            Logger logger = new Logger();

            logger.Info("TestMessage.");
            logger.Warn("TestMessage.");
            logger.Error("TestMessage.");
            logger.Fatal("TestMessage.");
            logger.Debug("TestMessage.");

        }
    }
}
