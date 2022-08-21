using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperWinForms
{
    public class Meet1_Tuple
    {
        public void Run()
        {
            (int id, string fname, string lname) var1;
            var1 = (123, "moshe", "Choen");

            var newPerson = CreatePerson();

        }

        public (int id, string fname, string lname) CreatePerson()
        {
            (int id, string fname, string lname) var1 = (123, "moshe", "Choen");
            return var1;
        }

    }


}
