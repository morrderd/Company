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
            Client client = new Client();
            client.Name = "Imie";
            client.Surname = "Nazwisko";

            string expectedFullName = "Imie Nazwisko";
            
            string actualFullName = client.FullName;
            
            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [TestMethod]
        public void EmptyNameFullNameTest()
        {
            Client client = new Client();
            client.Surname = "Nazwisko";

            string expectedFullName = "Nazwisko";

            string actualFullName = client.FullName;

            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [TestMethod]
        public void EmptySurrnameFullNameTest()
        {
            Client client = new Client();
            client.Name = "Imie";

            string expectedFullName = "Imie";

            string actualFullName = client.FullName;

            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [TestMethod]
        public void ClientCounterTest()
        {
            Client client1 = new Client();
            client1.Name = "Klient1";
            Client.Counter += 1;

            Client client2 = new Client();
            client2.Name = "Klient2";
            Client.Counter += 1;

            Client client3 = new Client();
            client3.Name = "Klient3";
            Client.Counter += 1;

            Assert.AreEqual(3, Client.Counter);
        }

        [TestMethod]
        public void PropertyValidation()
        {
            Client client = new Client();
            client.Email = "mail@mail.com";

            var expected = true;
            var actual = client.Validation(client.Email);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PropertyValidationNull()
        {
            Client client = new Client();
            client.Email = "";

            var expected = false;
            var actual = client.Validation(client.Email);

            Assert.AreEqual(expected, actual);
        }
    }
}
