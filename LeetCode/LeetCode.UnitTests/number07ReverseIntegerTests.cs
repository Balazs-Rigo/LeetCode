using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LeetCode.Easy;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class number07ReverseIntegerTests
    {

        [Test]
        public void Reverse_WhenCalled_ReturnReversedInt()
        {
            var result = number07ReverseInteger.Reverse2(12345);

            Assert.That(result, Is.EqualTo(54321));
        }
    }
}
