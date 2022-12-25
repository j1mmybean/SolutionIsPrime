
using Utilities;
namespace IsPrime.UnitTests
{
    public class IsPrimeTest
    {
        [TestCase(100,false)]
        [TestCase(1,false)]
        [TestCase(4,false)]
        [TestCase(6,false)]
        public void IsPrime��J���O��ƴN�Ǧ^false(int source, bool expected)
        {
            bool actual = source.IsPrime();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(97, true)]
        public void IsPrime��J��ƴN�Ǧ^true(int source, bool expected)
        {
            bool actual = source.IsPrime();

            Assert.AreEqual(expected, actual);
        }

    }
}