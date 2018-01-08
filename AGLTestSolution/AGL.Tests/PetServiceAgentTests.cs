using System;
using AGL.ServiceAgent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

namespace AGL.Tests
{
    [TestClass]
    public class PetServiceAgentTests
    {

        [TestInitialize]
        public void Setup()
        {

        }
        

        [TestMethod]
        public void Can_get_pet_information_using_service_agent()
        {
            var fixture = new Fixture();
            var serviceAgent = fixture.Create<PetServiceAgent>();
            var petInformation = serviceAgent.GetPetInformation();
            Assert.IsNotNull(petInformation);
            //Assert.IsTrue(petInformation);
        }
    } 
}
 