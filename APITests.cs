using NUnit.Framework;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SeleniumApp1
{
    internal class APITests
    {
        [Test]
        public async Task APITest1()
        {
            TestAPI api = new TestAPI();

            var response = await api.testRequest();
            //var jsonString = JsonSerializer.Serialize(response);

            //Assert.That(jsonString, Is.EqualTo("animals"));
            Assert.IsNotNull(response);

            Animals animals = JsonSerializer.Deserialize<Animals>(response);

            Assert.AreEqual(26, animals.entries.Length);
            Assert.AreEqual(26, animals.count);
            //JsonDocument.Parse not needed since we have model/properties
            Assert.AreEqual("Axolotl", animals.entries[1].API);

        }

    }
}
