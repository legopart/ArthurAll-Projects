using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Interfaces;

namespace ewmsCsharp.Classes
{
    public class DataDate : IDataDate
    {
        #region Public members
        public DateTime CreateDate { get; private set; } = DateTime.Now;
        public DateTime EditDate { get; private set; } = DateTime.MinValue;
        public DateTime OnProcessDate { get; private set; } = DateTime.MinValue;
        public bool Active { get => _active; set { _active = value; EditeDate_SetActual(); } }
        #endregion

        #region Private members
        /// <summary>
        /// Get Defult Values
        /// </summary>
        private bool _active = true;
        #endregion


        #region Constractors (empty)
        /// <summary>
        /// No Constractor
        /// </summary>
        #endregion

        #region Public methods
        #region Overrides
         public string DataString()
                => $"Create Date: {CreateDate}\t\tEdited Date: {EditDate}\t\t Active: {Active}\n";
        #endregion
        #endregion

        #region Protected methods
        protected void EditeDate_SetActual() { EditDate = DateTime.Now; }
        protected void OnProcessDate_SetActual() { OnProcessDate = DateTime.Now; }
        #endregion

        #region Private methods (empty)
        #endregion

    }
}
