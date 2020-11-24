using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using Validators;

namespace IcValidatorTest
{
    [TestClass]
    public class MyIcValidatorTests
    {
        [TestMethod]
        public void CheckValidIc1()
        {
            MyIcValidator a = new MyIcValidator();
            Assert.IsTrue(a.Validate("75598817"));
        }

        [TestMethod]
        public void CheckInvalidIc1()
        {
            MyIcValidator a = new MyIcValidator();
            Assert.IsFalse(a.Validate("04408697"));
        }

        [TestMethod]
        public void SumNumbers()
        {
            MyIcValidator a = new MyIcValidator();
            int result = (int)a.GetType().GetMethod("SumNumbers", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(a, new object[] {"75598817"});
            
            Assert.AreEqual(224, result);
        }
        [TestMethod, ExpectedException(typeof(InvalidDataException))]
        public void SumNumbers2()
        {
            try
            {
                MyIcValidator a = new MyIcValidator();
                int result = (int)a.GetType().GetMethod("SumNumbers", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(a, new object[] { "7a55" });
            }
            catch(TargetInvocationException e)
            {
                throw e.InnerException;
            }

        }

        [TestMethod]
        public void CheckCTest()
        {
            MyIcValidator a = new MyIcValidator();
            try
            {
                bool res = (bool)a
                    .GetType()
                    .GetMethod("CheckC", BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(a, new object[] { 7, 224 % 11 });
                Assert.IsTrue(res);
            }
            catch(TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}
