
using Utilities;
namespace IsPrime.UnitTests
{
    public class IsPrimeTest
    {
        [TestCase(100,false)]
        [TestCase(1,false)]
        [TestCase(4,false)]
        [TestCase(6,false)]
        public void IsPrime輸入不是質數就傳回false(int source, bool expected)
        {
            bool actual = source.IsPrime();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(97, true)]
        public void IsPrime輸入質數就傳回true(int source, bool expected)
        {
            bool actual = source.IsPrime();

            Assert.AreEqual(expected, actual);
        }

    }
}