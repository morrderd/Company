using System;
using Company;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyTests
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void FullNameTest()
        {
            //Arange
            Client client = new Client();
            client.Name = "Imie";
            client.Surname = "Nazwisko";

            string expectedFullName = "Imie Nazwisko";
            //Act
            string actualFullName = client.FullName;
            //Assert
            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [TestMethod]
        public void EmptyNameFullNameTest()
        {
            //Arange
            Client client = new Client();
            client.Surname = "Nazwisko";

            string expectedFullName = "Nazwisko";
            //Act
            string actualFullName = client.FullName;
            //Assert
            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [TestMethod]
        public void EmptySurrnameFullNameTest()
        {
            //Arange
            Client client = new Client();
            client.Name = "Imie";

            string expectedFullName = "Imie";
            //Act
            string actualFullName = client.FullName;
            //Assert
            Assert.AreEqual(expectedFullName, actualFullName);
        }
    }
}
