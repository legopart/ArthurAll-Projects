using NUnit.Framework;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace Exercise_08.RestSharp
{
    [TestFixture]
    internal class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Number_of_posts_is_100()
        {
            RestClient client = new RestClient("http://jsonplaceholder.typicode.com/posts");
            RestRequest request = new RestRequest();

            var response = await client.GetAsync(request);
            JArray body = JArray.Parse(response.Content);

            Assert.That(body.Count, Is.EqualTo(100));
        }

        [Test]
        public async Task Title_contains_specific_text​()
        {

            RestClient client = new RestClient("http://jsonplaceholder.typicode.com/");
            RestRequest request = new RestRequest("posts/1");

            var response = await client.GetAsync(request);
            JObject body = JObject.Parse(response.Content);

            string title_value = (string)body["title"];
            Assert.That(title_value, Does.Contain("sunt aut facere repellat provident occaecati excepturi optio reprehenderit"));
        }

        [Test]
        public async Task Create_todo_and_get_todo_by_ID()
        {
            string newPost = @"{                                
                                'title':'test',
                                'doneStatus':false,
                                'description':'RestSharp'
                                }";

            RestClient client = new RestClient("http://apichallenges.herokuapp.com/todos");
            RestRequest request = new RestRequest();

            request.AddParameter("application/json", newPost, ParameterType.RequestBody);
            var response = await client.PostAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            Get_todo_by_ID();
        }
        public async Task Get_todo_by_ID()
        {
            RestClient client = new RestClient("http://apichallenges.herokuapp.com/todos");
            RestRequest request = new RestRequest();

            var response = await client.GetAsync(request);
            JObject body = JObject.Parse(response.Content.ToString());
            JArray body_array = (JArray)body["todos"];

            for (int i = 1; i < body_array.Count; i++)
            {
                if ((string)body_array[i]["title"] == "test")
                {
                    int id_value = (int)body_array[i]["id"];
                    RestRequest request_byID = new RestRequest("/{id}");
                    request_byID.AddUrlSegment("id", id_value);

                    var response_get = await client.GetAsync(request_byID);
                    JObject body_get = JObject.Parse(response_get.Content.ToString());
                    JArray body_get_todos = (JArray)body_get["todos"];

                    string title_value = (string)body_get_todos["title"];
                    string description_value = (string)body_get_todos["description"];

                    Assert.That(description_value, Is.EqualTo("RestSharp"));
                    Assert.That(title_value, Is.EqualTo("TEST"));
                    break;
                }
            }
        }

        [Test]
        public async Task Create_todo_and_check_it_was_added_use_hasItem()
        {
            string newTodo = @"{                                
                                'title':'TEST_2',
                                'doneStatus':false,
                                'description':'use hasItem'
                                }";

            RestClient client = new RestClient("http://apichallenges.herokuapp.com/todos");
            RestRequest request = new RestRequest();
            request.AddParameter("application/json", newTodo, ParameterType.RequestBody);

            var response = await client.PostAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            Check_it_was_added_use_hasItem();
        }
        public async Task Check_it_was_added_use_hasItem()
        {
            RestClient client = new RestClient("http://apichallenges.herokuapp.com/todos");
            RestRequest request = new RestRequest();

            var response = await client.GetAsync(request);
            JObject body = JObject.Parse(response.Content.ToString());
            JArray body_todos = (JArray)body["todos"];

            for (int i = 1; i < body_todos.Count; i++)
            {
                if ((string)body_todos[i]["title"] == "TEST_2")
                {
                    int id_value = (int)body_todos[i]["id"];
                    RestRequest request_byID = new RestRequest("/{id}");
                    request_byID.AddUrlSegment("id", id_value);

                    var response_get = await client.GetAsync(request_byID);
                    JObject body_get = JObject.Parse(response_get.Content.ToString());
                    JArray body_get_todos = (JArray)body_get["todos"];

                    string description_value = (string)body_get_todos["description"];

                    //Assert.That(description_value, Has.ItemAt(get_body[], "use hasItem"));                    
                    Assert.That(description_value, Is.EqualTo("use hasItem"));
                    //break;
                }
            }



        }
        [Test]
        public async Task Create_todo_update_and_delete_it()
        {
            string newPost = @"{                                
                                'title':'TEST_3',
                                'doneStatus':false,
                                'description':'GET_PUT_DELETE'
                                }";

            RestClient client = new RestClient("http://apichallenges.herokuapp.com/todos");
            RestRequest request = new RestRequest();

            request.AddParameter("application/json", newPost, ParameterType.RequestBody);
            var response = await client.PostAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));

            Update_todo();
            Delete_todo();
        }
        public async Task Update_todo()
        {
            RestClient client = new RestClient("http://apichallenges.herokuapp.com/todos");
            RestRequest request = new RestRequest();

            var response = await client.GetAsync(request);
            JObject body = JObject.Parse(response.Content.ToString());
            JArray body_todos = (JArray)body["todos"];

            for (int i = 1; i < body_todos.Count; i++)
            {
                if ((string)body_todos[i]["title"] == "TEST_3")
                {
                    int id_value = (int)body_todos[i]["id"];
                    RestRequest request_update = new RestRequest("/{id}");
                    request_update.AddUrlSegment("id", id_value);

                    string updateBody = @"{
                                           'title':'TEST_3',
                                           'doneStatus':true,
                                           'description':'GET_PUT_DELETE'
                                            }";

                    request_update.AddParameter("application/json", updateBody, ParameterType.RequestBody);

                    var response_put = await client.PutAsync(request_update);
                    JObject newBody = JObject.Parse(response_put.Content.ToString());
                    bool doneStatus_now = (bool)newBody["doneStatus"];
                    Assert.That(doneStatus_now, Is.EqualTo(true));
                    break;
                }
            }
        }
        public async Task Delete_todo()
        {
            RestClient client = new RestClient("http://apichallenges.herokuapp.com/todos");
            RestRequest request = new RestRequest();

            var response = await client.GetAsync(request);
            JObject body = JObject.Parse(response.Content.ToString());
            JArray body_todos = (JArray)body["todos"];

            for (int i = 1; i < body_todos.Count; i++)
            {
                if ((string)body_todos[i]["title"] == "TEST_3")
                {
                    int id_value = (int)body_todos[i]["id"];                   
                    RestRequest request_delete = new RestRequest("/{id}");
                    request_delete.AddUrlSegment("id", id_value);

                    var response_delete = await client.DeleteAsync(request_delete);
                    JObject body_now = JObject.Parse(response.Content);
                    string title_now = (string)body_now["title"];
                    
                    Assert.That(response_delete.StatusCode, Is.EqualTo(HttpStatusCode.OK));                    
                    break;
                }
            }
        }
    }
}