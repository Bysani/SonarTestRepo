using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AddTwoNumbers()
        {
            int a = 5;
            int b = 5;
            Assert.True(a + b > 0);

        }
    }
}
