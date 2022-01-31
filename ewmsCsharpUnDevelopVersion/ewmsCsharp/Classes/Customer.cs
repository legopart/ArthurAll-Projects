using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using ewmsCsharp.Classes;
using ewmsCsharp.Interfaces;

namespace ewmsCsharp.Classes
{
    public class Customer : Data, ICustomer, IDataImage
    {
        #region Public members
        public DateTime BeginingServies { get => _beginingServies; set { _beginingServies = value; EditeDate_SetActual(); } }
        public string PhoneNumber { get => _phoneNumber; set { _phoneNumber = value; EditeDate_SetActual(); } }
        public string Address { get => _address; set { _address = value; EditeDate_SetActual(); } }
        public bool IsImage { get => _isImage; set { _isImage = value; EditeDate_SetActual(); } }
        #endregion

        #region Private members
        /// <summary>
        /// Get Defult Values
        /// </summary>
        private DateTime _beginingServies = DateTime.MinValue;
        private string _phoneNumber = string.Empty;
        private string _address = string.Empty;
        private bool _isImage = false;   //IDataImage
        #endregion

        #region Constractors
        
        public Customer(string id, string name) : base(id, name) { }

        [JsonConstructor]
        public Customer(string id, string name, DateTime beginingServies, string phoneNumber, string address, bool isImage) : this(id, name)
        {
            BeginingServies = beginingServies;
            PhoneNumber = phoneNumber;
            Address = address;
            IsImage = isImage;
        }
        #endregion

        #region Public methods
        #region Overrides
        public override string ToString()
        {
            return base.ToString()+
                $"Begin Service: {BeginingServies}\t\tHasImage:{IsImage}\n" +
                $"Phone Number: {PhoneNumber}\t\t Address: {Address}\n";
        }
        #endregion
        #endregion

        #region Private methods (empty)
        #endregion

    }
}
