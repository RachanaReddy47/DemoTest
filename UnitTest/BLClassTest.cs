using BusinessLayer;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTest
{
    [TestClass]
    public class BLClassTest
    {
        [TestMethod]
        public void DivideTest()
        {
            //Arrange-Declare Actuals and Expected
            int Numerator = 10;
            int Denominator = 2;
            int Expected = 5;
            int Actual = 0;

            //Act- Call the method and pass the actuals as parameters
            BLClass BL = new BLClass();
            Actual= BL.Divide(Numerator.ToString(), Denominator.ToString());

            //Assert-check whether Actuals are matching with expected
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void DivideTest1()
        {
            //Arrange-Declare Actuals and Expected
            int Numerator = 0;
            int Denominator = 2;
            int Expected = 0;
            int Actual = 0;

            //Act- Call the method and pass the actuals as parameters
            BLClass BL = new BLClass();
            Actual = BL.Divide(Numerator.ToString(), Denominator.ToString());

            //Assert-check whether Actuals are matching with expected
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void DivideTest2()
        {
           
            int Numerator = 6;
            int Denominator = 0;
            BLClass BL = new BLClass();
            var exc = Assert.ThrowsException<DivideByZeroException>(() => BL.Divide(Numerator.ToString(), Denominator.ToString()));
            Assert.AreEqual("Cannot Divide By Zero", exc.Message);
        }

        [TestMethod]
        public void DivideTest3()
        {

            
            BLClass BL = new BLClass();
            var exc = Assert.ThrowsException<FormatException>(() => BL.Divide("abc","xyz"));
            Assert.AreEqual("only numbers", exc.Message);


        }

        [TestMethod]
        public void DivideTest4()
        {
            DateTime Dob =DateTime.Parse("03-12-1998");
            BLClass BL = new BLClass();
            int Expexted = 21;
            int Actual=BL.Age(Dob);
            Assert.AreEqual(Expexted, Actual);
        }

        [TestMethod]
        public void DivideTest5()
        {
            DateTime Dob = DateTime.Parse("03-12-2020");
            BLClass BL = new BLClass();
            var Actual =Assert.ThrowsException<CustomException>(()=> BL.Age(Dob));
            Assert.AreEqual("Age should be between 18 and 60", Actual.Message);
        }
    }
}
