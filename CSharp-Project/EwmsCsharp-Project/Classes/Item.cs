using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Classes;
using ewmsCsharp.Enums;
using ewmsCsharp.Interfaces;
using Newtonsoft.Json;


namespace ewmsCsharp.Classes
{
    public class Item : Data, IItem, IDataImage
    {
        #region Public members
        public ItemStorage Storage { get => _storage; set { _storage = value; EditeDate_SetActual(); } }

        public ItemEnums.ItemType Type { get => _type;  set { _type = value; EditeDate_SetActual(); } }
        public ItemEnums.ItemCategory Category { get => _category;  set { _category = value; EditeDate_SetActual(); } }
        public string Description { get => _description;  set { _description = value; EditeDate_SetActual(); } }
        public bool IsImage { get => _isImage;  set { _isImage = value; EditeDate_SetActual(); } }
        #endregion

        #region Private members
        /// <summary>
        /// Get Defult Values
        /// </summary>
        private ItemStorage _storage = new ItemStorage(); // how set null?
        private ItemEnums.ItemType _type = ItemEnums.ItemType.Global;
        private ItemEnums.ItemCategory _category = ItemEnums.ItemCategory.Global;
        private string _description = string.Empty;
        private bool _isImage = false; //IDataImage
        #endregion

        #region Constractors
        public Item(string id, string name) : base(id, name) { }

        [JsonConstructor]
        public Item(string id, string name, ItemEnums.ItemType type, ItemEnums.ItemCategory category, string description, bool isImage) : this(id, name)
        {
            Type = type;
            Category = category;
            Description = description;
            IsImage = isImage;
        }
        #endregion

        #region Public methods
        #region Overrides
        public override string ToString()
            => base.ToString() +
                $"Type: {Type}\t\tCategory: {Category}\t\tHasImage:{IsImage}\n" +
                $"Storage: {Storage}\n" +
                $"Description: {Description}\n" +
                "";//  .base.DataString();
        #endregion
        #endregion

        #region Private methods (empty)
        #endregion
        
    }
}
