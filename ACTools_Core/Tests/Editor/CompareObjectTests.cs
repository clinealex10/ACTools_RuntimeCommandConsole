using NUnit.Framework;
using UnityEngine;

namespace ACTools.Core.Tests.EditMode
{
    public class CompareObjectTests
    {
        [Test]
        public void ByName_WhenXIsFirst_ReturnNegitive()
        {
            GameObject object1 = new GameObject();
            object1.name = "Ken";

            GameObject object2 = new GameObject();
            object2.name = "Kevin";

            Assert.IsTrue(CompareObjects.ByName(object1, object2) <= 0);
        }

        [Test]
        public void ByName_WhenXIsSecond_ReturnPositive()
        {
            GameObject object1 = new GameObject();
            object1.name = "Kevin";

            GameObject object2 = new GameObject();
            object2.name = "Ken";

            Assert.IsTrue(CompareObjects.ByName(object1, object2) >= 0);
        }

        [Test]
        public void ByName_WhenXIsY_Zero()
        {
            GameObject object1 = new GameObject();
            object1.name = "Ken";

            GameObject object2 = new GameObject();
            object2.name = "Ken";

            Assert.IsTrue(CompareObjects.ByName(object1, object2) == 0);
        }
    }
}