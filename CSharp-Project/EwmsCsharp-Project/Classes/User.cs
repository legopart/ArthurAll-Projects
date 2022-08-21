using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json.Serialization;

using ewmsCsharp.Interfaces;
using ewmsCsharp.Enums;

namespace ewmsCsharp.Classes
{
    public class User : Data, IUser
    {
        #region Public members
      //  public new string Id { get => _id; set { _id = value; EditeDate_SetActual(); } }
      //  public new string Name { get => _name; set { _name = value; EditeDate_SetActual(); } }
        public string Password { get => _password; set { _password = value; EditeDate_SetActual(); } }
        public int AccessLevel { get => _accessLevel; set { _accessLevel = value; EditeDate_SetActual(); } }
        public UserEnums.UserRank Rank { get => _rank; set { _rank = value; EditeDate_SetActual(); } }
        #endregion

        #region Private members
        /// <summary>
        /// Get Defult Values
        /// </summary>
        //private string _id;
        //private string _name;
        private string _password;
        private int _accessLevel;
        private UserEnums.UserRank _rank;
        #endregion

        #region Constractors
        [JsonConstructor]
        public User(string id, string name, string password, int accessLevel) :base(id, name)
        {
            Password = password;
            AccessLevel = accessLevel;
        }
        #endregion

        #region Public methods
        #region Overrides
        public override string ToString()
            => base.ToString()+
                $"Passport #{Id}\t\tFull Name:{Name}\t\tPassword:****\t\tAccess Level #{AccessLevel}\n";
        #endregion
        #endregion

        #region Private methods (empty)
        #endregion

    }
}
