using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json.Serialization;

using ewmsCsharp.Classes;
using ewmsCsharp.Interfaces;

namespace ewmsCsharp.Classes
{
    public class ItemInOrder : Data, IItemInOrder
    {
        #region Public members
        public Item Item { get; set; }
        public double QuantityRequired { get => _quantityRequired; set { _quantityRequired = value; EditeDate_SetActual(); } }
        public bool RequiredSupplied { get => _requiredSupplied; set { _requiredSupplied = value; EditeDate_SetActual(); } }
        public double QuantityOutSourcing { get => _quantityOutSourcing; set { _quantityOutSourcing = value; EditeDate_SetActual(); } }
        public bool OutSourcingSupplied { get => _outSourcingSupplied; set { _outSourcingSupplied = value; EditeDate_SetActual(); } }
        public double PriceOrderedItem { get => _priceOrderedItem; set { _priceOrderedItem = value; EditeDate_SetActual(); } }
        #endregion

        #region Private members
        /// <summary>
        /// Get Defult Values
        /// </summary>
        
        private static int _counter = 0;
        //private Item _item;
        private double _quantityRequired = 0;
        private bool _requiredSupplied = false;
        private double _quantityOutSourcing = 0;
        private bool _outSourcingSupplied = false;
        private double _priceOrderedItem = 0;
        #endregion

        #region Constractors

        public ItemInOrder() : base(_counter++.ToString(), "ItemInOrder")
        {
        }

        public ItemInOrder(Item item) : base(_counter++.ToString(), "ItemInOrder") 
        {
            Item = item;
        }

        public ItemInOrder(Item item, double quantityRequired, double priceOrderedItem)
            : this(item)
        {
            QuantityRequired = quantityRequired;
            PriceOrderedItem = priceOrderedItem;
        }
         public ItemInOrder(Item item, double quantityRequired, bool requiredSupplied, double quantityOutSourcing, bool outSourcingSupplied, double priceOrderedItem)
            : this(item, quantityRequired, priceOrderedItem)
        {
            RequiredSupplied = requiredSupplied;
            QuantityOutSourcing = quantityOutSourcing;
            OutSourcingSupplied = outSourcingSupplied;
        }

        #endregion

        #region Public methods
        #region Overrides
        public override string ToString()
            => $"Item #{Item.Id} Name: {Item.Name}\t Stored Quantity: {Item.Storage.Quantity} {Item.Storage.Measurments}\n" +
                $"Required Quantity: {QuantityRequired} {Item.Storage.Measurments}\t\tOut Sourcing Quantity-->{QuantityOutSourcing}\t\t Pricing per item: {PriceOrderedItem}$ \n" +
                $"\t\t Quantity Supplied:{RequiredSupplied}\t Out Sourcing Quantity Suplied:{OutSourcingSupplied}\n" +
                "";//      $"Storage: {Item.Storage}";
        #endregion
        #endregion

        #region Private methods (empty)
        #endregion

    }
}
