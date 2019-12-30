using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace SampleTest
{
    
    public class Test
    {
        [Fact]
        public void AddTwoNumbers()
        {
            int a = 5;
            int b = 5;
            Assert.True(a+b>0);
        }
    }
}
