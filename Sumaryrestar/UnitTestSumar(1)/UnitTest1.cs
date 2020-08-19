using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar__.Controllers;

namespace UnitTestSumar_1_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {


            //Arrange
            Sumacontroller sumaController = new Sumacontroller();
            int a = 5;
            int b = 8;
            int esperado = 13;

            //Act
            int resultado = sumaController.Add(a, b);



            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
