using System;
using Xunit;
using DotNetSession1;

namespace FindLengthTest
{
    public class UnitTest1
    {
        [Fact]
        public void FindLengthTest()
        {
            Assert.Equal(6, LengthHelper.findLength("nitesh"));
        }

        [Fact]
        public void FindLengthTest1()
        {
            Assert.Equal(0, LengthHelper.findLength(""));
        }

        [Fact]
        public void FindLengthTest2()
        {
            Assert.Equal(3, LengthHelper.findLength("123"));
        }

        [Fact]
        public void FindLengthTest3()
        {
            Assert.Equal(12, LengthHelper.findLength("123456789010"));
        }

        [Fact]
        public void FindLengthTest4()
        {
            Assert.Throws<NullReferenceException>(() => LengthHelper.findLength(null));
        }

        [Theory]
        [InlineData("nitesh Chaudhary")]
        public void FindLengthWithTheoryTest1(string value)
        {
            Assert.Equal(16, LengthHelper.findLength(value));
        }


        [Theory]
        [InlineData("")]
        public void FindLengthWithTheoryTest2(string value)
        {
            Assert.Equal(0, LengthHelper.findLength(value));
        }

        [Theory]
        [InlineData("123")]
        public void FindLengthWithTheoryTest3(string value)
        {
            Assert.Equal(3, LengthHelper.findLength(value));
        }

        [Theory]
        [InlineData("123456789010")]
        public void FindLengthWithTheoryTest4(string value)
        {
            Assert.Equal(12, LengthHelper.findLength(value));
        }
    }
}
