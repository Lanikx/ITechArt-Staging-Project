using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using Staging_project.Models;
using Staging_project.RestSharp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Tests.API_testing
{
    [Parallelizable(ParallelScope.All)]
    class RestSharpTesting
    {
        readonly string url = "https://reqres.in/";
        IRestClient client;
        [SetUp]
        public void Begin()
        {
            client = new RestClient(url);
        }

        [Test]
        [TestCase(1)]
        public void GetUsersListTest(int id)
        {
            
            var response = GetResponse("/api/users?page={id}", "id", id.ToString());
            var content = JsonConvert.DeserializeObject<Users>(response.Content);
            Assert.That(content.page == id);
        }

        [Test]
        [TestCase(1, "George")]
        public void GetUserDataTest(int id, string name)
        {            
            var response = GetResponse("/api/users/{id}", "id", id.ToString());
            var content = JsonConvert.DeserializeObject<UserData>(response.Content);
            Assert.That(content.data.Id == id && content.data.FirstName == name);
        }

        [Test]
        [TestCase(23)]
        public void UserNotFoundTest(int id)
        {
            var response = GetResponse("/api/users/{id}", "id", id.ToString());
            Assert.That(!response.IsSuccessful);
        }

        [Test]
        public void ResourceListTest()
        {
            var response = GetResponse("/api/{id}", "id", "unknown");
            var content = JsonConvert.DeserializeObject<Resources>(response.Content);
            Assert.That(content.TotalPages == 2);
        }

        [Test]
        [TestCase(2)]
        public void SingleResourceTest(int id)
        {
            var response = GetResponse("/api/unknown/{id}", "id", id.ToString());
            var content = JsonConvert.DeserializeObject<ResourceData>(response.Content);
            Assert.That(content.Data.Id == id);
        }

        [Test]
        [TestCase(23)]
        public void SingleResourceNotFoundTest(int id)
        {
            var response = GetResponse("/api/unknown/{id}", "id", id.ToString());
            Assert.That(!response.IsSuccessful);
        }

        [Test]
        public void CreateUserTest()
        {
            var request = new RestRequest("/api/users", DataFormat.Json);
            request.AddParameter("name", "morpheus");
            request.AddParameter("job", "leader");
            var response = client.Post(request);
            var content = JsonConvert.DeserializeObject<PostedUser>(response.Content);
            Assert.That(content.Name == "morpheus");
        }

        [Test]
        public void UpdateUserTest()
        {
            var request = new RestRequest("/api/users/2", DataFormat.Json);
            request.AddParameter("name", "morpheus");
            request.AddParameter("job", "bigger");
            var response = client.Put(request);
            var content = JsonConvert.DeserializeObject<PostedUser>(response.Content);
            Assert.That(content.Job == "bigger");
        }

        [Test]
        public void DeleteUserTest()
        {
            var request = new RestRequest("/api/users/2", DataFormat.Json);
            var response = client.Delete(request);
            Assert.That(response.IsSuccessful);
        }

        [Test]
        public void SuccessfullRegisterTest()
        {
            var request = new RestRequest("/api/register", DataFormat.Json);
            request.AddParameter("email", "eve.holt@reqres.in");
            request.AddParameter("password", "pistol");
            var response = client.Post(request);
            var content = JsonConvert.DeserializeObject<LoginToken>(response.Content);
            Assert.That(content.Token == "QpwL5tke4Pnpja7X4");
        }

        [Test]
        public void UnsuccessfullRegisterTest()
        {
            var request = new RestRequest("/api/register", DataFormat.Json);
            request.AddParameter("email", "eve.holt@reqres.in");
            var response = client.Post(request);
            var content = JsonConvert.DeserializeObject<LoginToken>(response.Content);
            Assert.That(content.Error == "Missing password");
        }

        [Test]
        public void SuccessfullLoginTest()
        {
            var request = new RestRequest("/api/login", DataFormat.Json);
            request.AddParameter("email", "eve.holt@reqres.in");
            request.AddParameter("password", "pistol");
            var response = client.Post(request);
            var content = JsonConvert.DeserializeObject<LoginToken>(response.Content);
            Assert.That(content.Token == "QpwL5tke4Pnpja7X4");
        }

        [Test]
        public void UnsuccessfullLoginTest()
        {
            var request = new RestRequest("/api/register", DataFormat.Json);
            request.AddParameter("email", "eve.holt@reqres.in");
            var response = client.Post(request);
            var content = JsonConvert.DeserializeObject<LoginToken>(response.Content);
            Assert.That(content.Error == "Missing password");
        }

        [Test]
        [TestCase(3)]
        public void DelayedResponseTest(int id)
        {
            var response =  GetResponse("/api/users?delay={id}", "id", id.ToString());
            var content = JsonConvert.DeserializeObject<Users>(response.Content);
            Assert.That(content.page == 1);
        }

        public IRestResponse GetResponse(string requestUrl, string additionUrl, string additionValue)
        {
            var request = new RestRequest(requestUrl, DataFormat.Json);
            request.AddUrlSegment(additionUrl, additionValue);
            return client.Get(request);
        }



    }

   
}