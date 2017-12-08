using System;
using Task_1_ArturDovbysh;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Task_1_Vector3D.Tests
{
    [TestClass]
    public class OperatorsTests
    {
        [TestMethod]
        public void OperatorPlus_ShouldReturn_ExpectedValues()
        {
            bool flag = true; //indicates if everything works ok with operator+

            Vector3D v1 = new Vector3D();       //(0,0,0)
            Vector3D v2 = new Vector3D(1, 1, 1);

            Vector3D v3 = v1 + v2;

            if (v3 != new Vector3D(1, 1, 1))
                flag = false;

            v3 = v3 + v2;

            if (v3 != new Vector3D(2, 2, 2))
                flag = false;

            v3 = v3 + v1;

            if (v3 != new Vector3D(2, 2, 2))
                flag = false;

            Assert.IsTrue(flag);

        }

        [TestMethod]
        public void OperatorMinus_ShouldReturn_ExpectedValues()
        {
            bool flag = true; //indicates if everything works ok with operator+

            Vector3D v1 = new Vector3D();       //(0,0,0)
            Vector3D v2 = new Vector3D(1, 1, 1);

            Vector3D v3 = v1 - v2;

            if (v3 != new Vector3D(-1, -1, -1))
                flag = false;

            v3 = v3 - v2;

            if (v3 != new Vector3D(-2, -2, -2))
                flag = false;

            v3 = v3 - v1;

            if (v3 != new Vector3D(-2, -2, -2))
                flag = false;

            Assert.IsTrue(flag);

        }

        [TestMethod]
        public void OperatorGraterThan_ShouldReturn_True()
        {
            Vector3D v1 = new Vector3D(4, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Assert.IsTrue(v1 > v2);
        }

        [TestMethod]
        public void OperatorGraterThan_ShouldReturn_False()
        {
            Vector3D v1 = new Vector3D(4, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Assert.IsFalse(v2 > v1);
        }

        [TestMethod]
        public void OperatorLessThan_ShouldReturn_True()
        {
            Vector3D v1 = new Vector3D(4, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Assert.IsTrue(v2 < v1);
        }

        [TestMethod]
        public void OperatorLessThan_ShouldReturn_False()
        {
            Vector3D v1 = new Vector3D(4, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Assert.IsFalse(v1 < v2);
        }

        [TestMethod]
        public void OperatorEqualTo_ShouldReturn_True()
        {
            Vector3D v1 = new Vector3D(1, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Assert.IsTrue(v2 == v1);
        }

        [TestMethod]
        public void OperatorEqualTo_ShouldReturn_False()
        {
            Vector3D v1 = new Vector3D(2, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Assert.IsFalse(v2 == v1);
        }

        [TestMethod]
        public void OperatorNotEqualTo_ShouldReturn_True()
        {
            Vector3D v1 = new Vector3D(2, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Assert.IsTrue(v2 != v1);
        }

        [TestMethod]
        public void OperatorNotEqualTo_ShouldReturn_False()
        {
            Vector3D v1 = new Vector3D(1, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Assert.IsFalse(v2 != v1);
        }
    }
}
