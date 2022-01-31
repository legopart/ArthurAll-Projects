using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using Microsoft.Azure.Cosmos;

namespace SolutionCosmosDB_Temp
{
    public class Family
    {


        public async Task AddItem(CosmosDB cosmosDB)
        {
            PartitionKey partitionKey = new PartitionKey(LastName);
            try
            {
                ItemResponse<Family> andersenFamilyResponse = await cosmosDB.Container.ReadItemAsync<Family>(Id, partitionKey);
                Console.WriteLine("Item in database with id: {0} already exists\n", andersenFamilyResponse.Resource.Id);
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                ItemResponse<Family> andersenFamilyResponse = await cosmosDB.Container.CreateItemAsync<Family>(this, partitionKey);

                Console.WriteLine("Created item in database with id: {0} Operation consumed {1} RUs.\n", andersenFamilyResponse.Resource.Id, andersenFamilyResponse.RequestCharge);
            }
        }

        public static async Task QueryItemsAsync(CosmosDB cosmosDB, string sqlQueryText)
        {
            Console.WriteLine("Running query: {0}\n", sqlQueryText);

            var query = cosmosDB.Query(sqlQueryText);
            FeedIterator<Family> queryResultSetIterator = cosmosDB.Container.GetItemQueryIterator<Family>();
            List<Family> families = new List<Family>();
            while (queryResultSetIterator.HasMoreResults)
            {
                FeedResponse<Family> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                foreach (Family family in currentResultSet)
                {
                    families.Add(family);
                    Console.WriteLine("\tRead {0}\n", family);
                    //turn to json
                }
            }
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string LastName { get; set; }
        public Parent[] Parents { get; set; }
        public Child[] Children { get; set; }
        public Address Address { get; set; }
        public bool IsRegistered { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Parent
    {
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
    }

    public class Child
    {
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int Grade { get; set; }
        public Pet[] Pets { get; set; }
    }

    public class Pet
    {
        public string GivenName { get; set; }
    }

    public class Address
    {
        public string State { get; set; }
        public string County { get; set; }
        public string City { get; set; }
    }
}

