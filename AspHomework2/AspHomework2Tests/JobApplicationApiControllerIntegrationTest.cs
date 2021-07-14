using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using ASPHomework.Persistence;
using AspHomework2;
using AspHomework2.Persistence;
using AspHomework2.Persistence.Repositories;
using AspHomework2Tests.WebApplicationFactory;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace AspHomework2Tests
{
    [TestClass]
    public class JobApplicationApiControllerIntegrationTest
    {
        private HttpClient _client;
        private TestsWebApplicationFactory<Startup> _factory;
        
        [TestInitialize]
        public void Init()
        {
            _factory = new TestsWebApplicationFactory<Startup>();
            _client = _factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        
        [TestMethod]
        public void TestPostSuccess()
        {
            var dto = new
            {
                email = "ales@kutek.cz",
                phone = "+420 735 913 032",
                content = "xxxx",
                cvBase64 = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8/5+hHgAHggJ/PchI7wAAAABJRU5ErkJggg==",
                cvFileName = "obrazek.png",
                jobPositionId = 1
            };

            var serializedJson = JsonConvert.SerializeObject(dto);
            
            var response = _client.PostAsync("/api/jobApplication", new StringContent(serializedJson, Encoding.UTF8, "application/json")).Result;
            response.EnsureSuccessStatusCode();

            var body = response.Content.ReadAsStringAsync().Result;

            Assert.AreEqual(body, "{\"success\":true}");
            
            
            using (var scope = _factory.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDatabaseContext>();
                var hostEnvironment = scope.ServiceProvider.GetRequiredService<IHostEnvironment>();

                var entity = dbContext.JobApplications.OrderByDescending(x => x.Id).Take(1).FirstOrDefault();
            
                Assert.IsNotNull(entity);

                var fileResponse = _client.GetAsync($"/files/{entity.CvFilePath}").Result;
                fileResponse.EnsureSuccessStatusCode();
            
                //uklizení souboru
                File.Delete(Path.Combine(hostEnvironment.ContentRootPath, "wwwroot/files", entity.CvFilePath));
            }
        }
        
        [TestMethod]
        public void TestPostFailed()
        {
            var dto = new
            {
                email = "ales@kutek.cz",
                phone = "+420735913032", //číslo je ve špatným formátu záměrně
                content = "xxxx",
                cvBase64 = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8/5+hHgAHggJ/PchI7wAAAABJRU5ErkJggg==",
                cvFileName = "obrazek.png",
                jobPositionId = 1
            };

            var serializedJson = JsonConvert.SerializeObject(dto);
            
            var response = _client.PostAsync("/api/jobApplication", new StringContent(serializedJson, Encoding.UTF8, "application/json")).Result;

            var body = response.Content.ReadAsStringAsync().Result;

            Assert.AreNotEqual(body, "{\"success\":true}");
        }
    }
}