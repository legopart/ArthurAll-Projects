using System;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Cosmos;
namespace SolutionCosmosDB_Temp
{



    class Program
    {

        //public CosmosClient cosmosClient = new CosmosClient("https://localhost:8081", "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");
        //public Database Database;
        //public Container Container;
        //public string DatabaseId = "ProLobbyDatabase";
        //public string ContainerId = "ProLobbyx";


        public static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("Beginning operations...\n");
                CosmosDB p = new CosmosDB();
                p.CosmosClient = new CosmosClient("https://localhost:8081", "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");
                await p.SetDatabaseAsync("ProLobbyDatabase");
                await p.SetContainerAsync("ProLobby9", "/LastName", 400);



                Family andersenFamily = new Family
                {
                    Id = "Andersen.1",
                    LastName = "Andersen",
                    Parents = new Parent[] { new Parent { FirstName = "Thomas" }, new Parent { FirstName = "Mary Kay" } },
                    Children = new Child[] { new Child { FirstName = "Henriette Thaulow", Gender = "female", Grade = 5, Pets = new Pet[] { new Pet { GivenName = "Fluffy" } } } },
                    Address = new Address { State = "WA", County = "King", City = "Seattle" },
                    IsRegistered = false
                };
                Family wakefieldFamily = new Family
                {
                    Id = "Wakefield.7",
                    LastName = "Wakefield",
                    Parents = new Parent[] { new Parent { FamilyName = "Wakefield", FirstName = "Robin" }, new Parent { FamilyName = "Miller", FirstName = "Ben" } },
                    Children = new Child[]
                    {
                    new Child { FamilyName = "Merriam", FirstName = "Jesse", Gender = "female", Grade = 8,  Pets = new Pet[]  { new Pet { GivenName = "Goofy" }, new Pet { GivenName = "Shadow" }  } },
                    new Child { FamilyName = "Miller",  FirstName = "Lisa", Gender = "female", Grade = 1 }
                    },
                    Address = new Address { State = "NY", County = "Manhattan", City = "NY" },
                    IsRegistered = true
                };

                //Add familt
                await andersenFamily.AddItem(p);
                await wakefieldFamily.AddItem(p);


                //Scale ?
                await p.ScaleContainerAsync();


                //prit query
                await Family.QueryItemsAsync(p, "SELECT * FROM c WHERE c.LastName = 'Andersen'");


                //Get Row and re set values
                ItemResponse<Family> wakefieldFamilyResponse = await p.Container.ReadItemAsync<Family>("Wakefield.7", new PartitionKey("Wakefield")); //getRow
                var itemBody = wakefieldFamilyResponse.Resource;
                itemBody.IsRegistered = true; // update registration status from false to true
                itemBody.Children[0].Grade = 6; // update grade of child
                wakefieldFamilyResponse = await p.Container.ReplaceItemAsync<Family>(itemBody, itemBody.Id, new PartitionKey(itemBody.LastName)); // replace the item with the updated content
                Console.WriteLine("Updated Family [{0},{1}].\n \tBody is now: {2}\n", itemBody.LastName, itemBody.Id, wakefieldFamilyResponse.Resource); // Replace an item in the container

                //Delete Row 
                var partitionKeyValue = "Wakefield";
                var familyId = "Wakefield.7";
                ItemResponse<Family> wakefieldFamilyResponse2 = await p.Container.DeleteItemAsync<Family>(familyId, new PartitionKey(partitionKeyValue)); // Delete an item. Note we must provide the partition key value and id of the item to delete
                Console.WriteLine("Deleted Family [{0},{1}]\n", partitionKeyValue, familyId); // Delete an item in the container

                //Delete Database
                //await p.DeleteThisDatabaseAsync();
                //await p.DeleteDatabaseAsync("ProLobbyDatabase");
            }
            catch { }
            finally
            {
                Console.WriteLine("End of demo, press any key to exit.");
                Console.ReadKey();
            }
        }






    }



}