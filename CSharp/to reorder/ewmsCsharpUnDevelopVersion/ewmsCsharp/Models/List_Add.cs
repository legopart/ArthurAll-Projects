using ewmsCsharp.Classes;
using ewmsCsharp.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ewmsCsharp.Models
{
    public class List_Add
    {
        private static ILogger<object> _logger = Logging.setLogger<List_Add>();


        /*
        public static ItemInOrder AddItemOrder(Item Item) {
        
        
        }
        */

        /// <summary>
        /// Add new Data to _____ List
        /// </summary>
        public static void AddStorage(string itemId, ItemStorage itemStorage)
        {
            //     dataTypeMessage = $"location = {(singleDataInput as ItemStorage).Location}";
            Item item = List.Items.Find(x => x.Id.ToString() == itemId.ToString());

            if (item == null)
            {    //Check if List.Items contain this Item. if not return /**/ /*.ToString()*/ 
                _logger.LogError($"This list of Item not contain this id: {itemId} couldn't add this storage, with location:{itemStorage.Location.ToString()}  to the item");
                return;
            }

            if (itemStorage.Location == "" //empti storage set
                || (
                item.Storage.Location.ToString() != itemStorage.Location.ToString() //its not the same item
                && List.ItemStorages.Find(listItem => listItem.Location.ToString() == itemStorage.Location.ToString() ) != null 
                // item not in storage list
                )
                )
            {
                _logger.LogError($"This list of ItemStorags contain this location:{itemStorage.Location} (or not empty)");
                return;
            }
            //check and awailable addid if this storage is the same item.storage!!!
           
           
            List.ItemStorages.Add(itemStorage);
            item.Storage = itemStorage;
            _logger.LogInformation($"ItemStorage added, location:{itemStorage.Location} for item id={item.Id}");
        }

        public static void AddOrder(string orderId, string userId, string customerId, List<Json_Classes.ItemInOrderAdd> itemInOrderAdd)
        {

            //Thread.Sleep(3000);
            if (orderId == null
                || userId == null
                || customerId == null
                || orderId == String.Empty
                || userId == String.Empty
                || customerId == String.Empty
                || List.Users.Any()!=true
                || List.Customers.Any()!=true
                )
            {
                _logger.LogError($"aaaaaaaaaaaaaaaaaaaaaaaaaaa\nOrder Received Null Values");
                Console.WriteLine(
                    //List.PrintList.PrintAll()
                    ) ;
                return;
            }

            

            Order order = List.Orders.Find(x => x.Id.ToString() == orderId.ToString());
            User user = List.Users.Find(x => x.Id.ToString() == userId);
            Customer customer = List.Customers.Find(x => x.Id.ToString() == customerId.ToString());
            List<ItemInOrder> itemInOrderList = new List<ItemInOrder>();



            //Check each Item before enter it to the order
            if (itemInOrderAdd.Any() && List.Items.Any() ) //itemInOrderAdd to itemInOrder List
            {
                foreach (Json_Classes.ItemInOrderAdd i in itemInOrderAdd)
                {
                    Item item = List.Items.Find(x => x.Id.ToString() == i.ItemId.ToString());

                    if (item == null)
                    {    //Check if List.Items contain this Item. if not return /**/ /*.ToString()*/ 
                        _logger.LogError($"Cant Add Item to Order Id: {orderId.ToString()}\n Item List not Contain Item Id: {i.ItemId.ToString()}");
                        // return; //dont return, only show error
                    }
                    else
                    {
                        //                        ItemInOrder itemInOrderx = new(item); //, 

                        ItemInOrder item1 = new(item: item, quantityRequired: i.QuantityRequired, priceOrderedItem: item.Storage.Price);

                        itemInOrderList.Add(item1);
                        
                        _logger.LogInformation($"+Order Id:{orderId} Added Item Id: {item1.Id}");
                    }


                }
                foreach (ItemInOrder i in itemInOrderList)  //Move all the template list to Orders list, if you not retun any error
                    List.ItemInOrders.Add(i);
            }






            Order newOrder = new(orderId, user, customer, itemInOrderList);
    List.Orders.Add(newOrder);

            _logger.LogInformation($"Order Id:{orderId} Added Successfully, by User Id: {userId}");
        }
        public static void AddData<T>(List<T> listToInput, T singleDataInput)
        {
            string nemeOfT = typeof(T).Name;

            string dataTypeMessage = string.Empty;
            
            void AddData_ErrorReturn()
            {
                _logger.LogError($"This list of {nemeOfT}s contain this {dataTypeMessage}");
                //throw new Exception($"This list of {typeOfT}s contain this ID= {singleDataInput.Id}");
            }

            switch (singleDataInput.GetType().Name) {
                case  nameof(ItemInOrder):
                    dataTypeMessage = $"item.id = {(singleDataInput as ItemInOrder).Id}";
                    if (listToInput.Find(listItem => (listItem as ItemInOrder).Item.Id.ToString() == (singleDataInput as ItemInOrder).Item.Id.ToString()) != null)
                    {
                        AddData_ErrorReturn();
                        return;
                    }
                    break;

                case nameof(Customer):
                case nameof(Item):
                case nameof(User):
                    dataTypeMessage = $"id = {(singleDataInput as Data).Id}";
                    if (listToInput.Find(listItem => (listItem as Data).Id.ToString() == (singleDataInput as Data).Id.ToString()) != null)
                    {
                        AddData_ErrorReturn();
                        return;
                    }
                    break;

                default:  //Error Message
                    _logger.LogError("Entered List and request to entered item that not typed as Data/ItemInOrder/ItemStorage Class\n" +
                        $"enterd class type is \"{singleDataInput.GetType().Name}\"");
                    return;
            }

            (listToInput as List<T>).Add(singleDataInput);
            _logger.LogInformation($"{nemeOfT} added, {dataTypeMessage}");
        }

        //Add try/catch
    }
}
