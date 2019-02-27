using Microsoft.VisualStudio.TestTools.UnitTesting;
using TLV_data_parser;

namespace TLVDataParser.UnitTest
{
    [TestClass]
    public class ClientTesting
    {
        [TestMethod]
        public void DoesEndClientExist_CLientExists_ReturnsTrue()
        {
            //Arrange (prepare object)
            var client = new ClientExisting();

            //Act (method)
            var result = client.Existing(new EndClient { EndpointClient = true });


            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DoesEndClientExist_ClientDoesNotExist_ReturnTrue()
        {
            var client = new ClientExisting();

            var result = client.Existing(new EndClient { EndpointClient = false });

            Assert.IsFalse(result);
            
        }
    }
}
