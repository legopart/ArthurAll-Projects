using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ewmsCsharp.Interfaces;

namespace ewmsCsharp.Classes
{
    public class Order : Data, IOrder
    {
        #region Public members
        public User User { get; set; }   //order created by
        public Customer Customer { get; set; } // order created for
        public List<ItemInOrder> ItemsInOrder { get; set; } // items inside the order
        #endregion

        #region Private members
        /// <summary>
        /// Get Defult Values
        /// </summary>
        private static int _runningNumber = 0;
        #endregion

        #region Constractors
        public Order(string id, User user, Customer customer, List<ItemInOrder> itemsInOrder)
            : base(id, "Required Order")
        {
            User = user;
            Customer = customer;
            ItemsInOrder = itemsInOrder;
        }

        public Order(User user, Customer customer, List<ItemInOrder> items)
            : this((_runningNumber++).ToString(), user, customer, items)
        {
            Name = "Entered Order";
        }
        #endregion

        #region Public methods (empty)
        #region Override
        public override string ToString()
        {
            string str = "";
            if (ItemsInOrder != null)
                foreach (ItemInOrder i in ItemsInOrder)
                    str += i;
            
            return base.ToString()+
                $"Order Made By User: {User.Name}\t\tFor Customer: {Customer.Name}\n" +
                $"User Id: {User.Id}\t\t\tCustomer Id: {Customer.Id}\n" +
                $"Items:\n" +
                str+
                $"- - -\t\t\t- - -\t\t\t- - -\t\t\t- - -\t\t\t- - -\n";
        }
        #endregion
        #endregion

        #region Private methods (empty)
        #endregion

        //toTtring
        // do you inherite Name for this Order class from Data ?
        // overide the id set - canceled
        // add editDate value for each list update
    }
}
