using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1_ArturDovbysh;

namespace Task_1_Vector3D.Tests
{
    [TestClass]
    public class FunctionsTests
    {
        [TestMethod]
        public void GetLength_ShouldReturn_ExpectedValues()
        {
            bool worksOk = true; //if changes to false -> cant pass the test

            Vector3D v1 = new Vector3D();

            if (v1.GetVectorLength() != 0)
                worksOk = false;

            Vector3D v2 = new Vector3D(0, 0, 3);

            if (v2.GetVectorLength() != 3)
                worksOk = false;

            Assert.IsTrue(worksOk);
        }

        [TestMethod]
        public void ScalarProduct_ShouldReturn_ExpectedValues()
        {
            bool worksOk = true; //if changes to false -> cant pass the test

            Vector3D v1 = new Vector3D();            
            Vector3D v2 = new Vector3D(1, 1, 1);

            if (Vector3D.ScalarProduct(v1,v2)!=0)
                worksOk = false;

            v1 = new Vector3D(1, 2, 3);

            if (Vector3D.ScalarProduct(v1, v2) != 6)
                worksOk = false;

            if (Vector3D.ScalarProduct(v1, new Vector3D(3, 2, 1)) != 10)
                worksOk = false;

            Assert.IsTrue(worksOk);
        }

        [TestMethod]
        public void VectorProduct_ShouldReturn_ExpectedVector()
        {
            Vector3D v1 = new Vector3D(1, 2, 3);
            Vector3D v2 = new Vector3D(3, 2, 1);

            Vector3D v3 = Vector3D.VectorProduct(v1, v2);

            Assert.IsTrue(v3.Equals(new Vector3D(-4, 8, -4)));

        }

        [TestMethod]
        public void MixedProduct_ShouldReturn_ExpectedValue()
        {
            Vector3D v1 = new Vector3D(1, 1, 1);
            Vector3D v2 = new Vector3D(0, 3, 6);
            Vector3D v3 = new Vector3D(5, 4, 1);

            Assert.IsTrue(Vector3D.MixedProduct(v1, v2, v3)==-6);
        }
    }
}
