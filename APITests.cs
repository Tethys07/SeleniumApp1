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
            Animals? animals;

            var response = await api.testRequest();
            //var jsonString = JsonSerializer.Serialize(response);

            Assert.IsNotNull(response);

            if (response != null)
            {
                animals = JsonSerializer.Deserialize<Animals>(response);
                Assert.AreEqual(26, animals.entries.Length);
                Assert.AreEqual(26, animals.count);
                //JsonDocument.Parse not needed since we have model/properties
                Assert.AreEqual("Axolotl", animals.entries[1].API);
            }
        }


        public async Task APITest2()
        {
            TestAPI testAPI = new TestAPI();
            Animals animal;

            var response = await testAPI.testRequest();

            animal = JsonSerializer.Deserialize<Animals>(response);
            Assert.AreEqual("Bear", animal.entries[2].API);




        }

















    }





}
