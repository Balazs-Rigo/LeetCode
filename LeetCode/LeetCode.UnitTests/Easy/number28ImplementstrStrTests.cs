using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy
{
    [TestFixture]
    public class number28ImplementstrStrTests
    {
        [Test]
        public void StrStr_IfNeedleIsNotPartOfTheHaystack_ReturnMinus1()
        {
            var result = number28ImplementstrStr.StrStr("bb","bbb");

            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void StrStr_IfNeedleIsPartOfTheHaystack_ReturnFirstOccurrence()
        {
            var result = number28ImplementstrStr.StrStr("RandomText", "ndom");

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void StrStr_SecondArgIsNllOrEmpty_ThrowsArgumentNullException()
        {
            Assert.That(() => number28ImplementstrStr.
            StrStr("randomText", ""), Throws.ArgumentNullException);
        }
    }
}
