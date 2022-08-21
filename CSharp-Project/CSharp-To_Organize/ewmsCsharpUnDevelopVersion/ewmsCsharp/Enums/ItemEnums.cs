using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ewmsCsharp.Enums
{
    public class ItemEnums
    {

        public enum ItemType
        {
            Global = 0,
            DataLimit,
            Broken,
            RegistrationRequire,
            Returnable,
            WarantyAccepted
        }

       public enum ItemCategory
        {
            Global = 0,
            Electricity,
            MusicInstrument,
        }
        
    }
}
