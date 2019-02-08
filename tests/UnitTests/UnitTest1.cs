using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
      

        [Fact]
        public void Add_WorksWithTwoNegativeIntegers()
        {
            var expected = -3;
            var a = -5;
            var b = -2;
            var actual = subtract(a, b);
            Assert.Equal(expected, actual);
        }

    


        [Theory]
        [InlineData(0, 2, 2)]
        [InlineData(-2, -7, -5)]
        [InlineData(0, 0, 0)]
        public void Add_WorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, subtract(n1, n2));
        }



        // for more see https://xunit.github.io/docs/getting-started/netcore/cmdline

        int subtract(int x, int y)
        {
            return x - y;
        }

      
    }
}
