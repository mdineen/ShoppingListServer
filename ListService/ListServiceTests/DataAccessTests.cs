using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListServiceTests
{
    [TestClass]
    public class DataAccessTests
    {
        [TestMethod]
        public void GetList()
        {
            var list = ListService.DataAccess.ListAccess.GetList(0);
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }
    }
}
