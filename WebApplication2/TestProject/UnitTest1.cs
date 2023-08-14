using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication1.Models;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            object a = "dfs";
            DBFIlterBase<UserProfile>.Test2(a);
        }
    }
}
