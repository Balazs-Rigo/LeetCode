using System;
using NUnit.Framework;
using LeetCode.Easy;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void number01TwoSum_WhenCalled_ReturnIndicesOfArrayOfTwoNumbersAddUpToTarget()
        {
            var result = number01TwoSum.TwoSum(new int[] {443,5,1,12},13);

            Assert.That(result, Is.EqualTo(new int[] {2,3}));
        }
    }
}
