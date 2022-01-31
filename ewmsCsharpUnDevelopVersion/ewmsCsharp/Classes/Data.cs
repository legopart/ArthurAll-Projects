using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Interfaces;

namespace ewmsCsharp.Classes
{
    public class Data : DataDate, IData
    {
        #region Public members
        public object Id { get; private set; }
        public string Name { get => _name; set { _name = value; EditeDate_SetActual(); } }
        public string Notes { get => _notes; set { _notes = value; EditeDate_SetActual(); } }
        #endregion

        #region Private members
        /// <summary>
        /// Get Defult Values
        /// </summary>
        private string _name;
        private string _notes;
        #endregion

        #region Constractors
        public Data(object id, string name)
        {
                Id = id;
                Name = name; 
        }
        #endregion

        #region Public methods
        #region Overrides
        public override string ToString()
            => $"{this.GetType().Name} #{Id}\t\tName: {Name}\n";
        #endregion
        #endregion
        
        #region Protected methods (empty)
        #endregion

        #region Private methods (empty)
        #endregion

        //public void Add();
        //public void Edit();
        //public void Delete();
        //Add not nullified values data!
    }
}
