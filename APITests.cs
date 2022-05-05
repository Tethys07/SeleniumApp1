using NUnit.Framework;


namespace SeleniumApp1
{
    internal class APITests
    {
        [Test]
        public async Task APITest1()
        {
            TestAPI api = new TestAPI();

            var response = await api.testRequest();


        }

    }
}
