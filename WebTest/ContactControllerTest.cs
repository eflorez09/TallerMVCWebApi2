using Core.Entities;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Web;
using WebTest.Controllers;
using Xunit;

namespace WebTest
{
    public class ContactControllerTest : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        public ContactControllerTest(CustomWebApplicationFactory<Startup> factory)
        {
            Client = factory.CreateClient();
        }

        public HttpClient Client { get; }

        [Fact]
        public async Task CreateContactTest()
        {
            Contact contact = new Contact
            {
                Name = "Elver Florez",
                Email = "elver@mail.com",
                Phone = "3123456789",
                Message = "Hola",
                RegistrationDate = DateTime.Now
            };

            StringContent body = new StringContent(JsonConvert.SerializeObject(contact));

            var response = await Client.PostAsync("/api/contact/contact", body);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();

            Assert.NotEqual(string.Empty, stringResponse);
        }
    }
}