using NUnit.Framework;
using SeleniumApp1.API.Models;
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
                //Assert.AreEqual(26, animals.entries.Length);   --converted to collection, length not necessary
                Assert.AreEqual(26, animals!.Count);   // ! tells compiler this will not be null and it will stop warning us about it
                //JsonDocument.Parse not needed since we have model/properties
                Assert.AreEqual("Axolotl", animals.Entry![1].API);
            }
        }

        [Test]
        public async Task APITest2()
        {
            TestAPI testAPI = new();
            Animals animal;

            var response = await testAPI.testRequest();

            animal = JsonSerializer.Deserialize<Animals>(response);
            Assert.AreEqual("Cats", animal!.Entry[4].API);

        }

        [Test]
        public async Task StockTrade01()
        {
            TestAPI testAPI = new();
            AppleStock appleStock;

            var response = await testAPI.StockRequest();

            appleStock = JsonSerializer.Deserialize<AppleStock>(response);
            //Assert.AreEqual("Cats", animal.entries[4].API);




        }
















    }





}
