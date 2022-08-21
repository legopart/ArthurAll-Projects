using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    public class Card
    {
        public int Id;
        public byte[] Numbers = new byte[6];
        public byte AddNum;
        //Date

        public void SortNumbers()
        { 
            Array.Sort(Numbers);
        }
    }
}
