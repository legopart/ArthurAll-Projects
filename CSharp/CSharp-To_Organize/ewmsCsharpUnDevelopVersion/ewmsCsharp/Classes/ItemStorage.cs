using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json.Serialization;

using ewmsCsharp.Interfaces;

namespace ewmsCsharp.Classes
{
    public class ItemStorage : DataDate, IItemStorage // only date no Id, Name
    {
        #region Public members
        public double Quantity { get => _quantity; set { _quantity = value; /* EditedDate(); */} }
        public string Measurments { get => _measurments; set { _measurments = value; /* EditedDate(); */} }
        public string Location { get => _location; set { _location = value; /* EditedDate(); */ } }
        public double Price { get => _price; set { _price = value; /* EditedDate(); */ } }
        #endregion

        #region Private members
        /// <summary>
        /// Get Defult Values
        /// </summary>
        private double _quantity = 0;
        private string _measurments = string.Empty;
        private string _location = string.Empty;
        private double _price = 0;
        #endregion

        #region Constractors
        public ItemStorage() {}

        public ItemStorage(double quantity, string measurments, string location, double price) : this() 
        {
            Quantity = quantity;
            Measurments = measurments;
            Location = location;
            Price = price;
        }
        #endregion

        #region Public methods
        #region Overrides
        public override string ToString()
            =>  $"Location: {Location}\t\t Quantity: {Quantity}{Measurments}\t\tCost: {Price}$";
        #endregion
        #endregion

        #region Private methods (empty)
        #endregion

        //edit date of the item itself when edit storage!
    }
}
