using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
#pragma warning disable  // Variable is assigned but its value is never used
    internal class _1_Tuple
    {

        // Tuple - אוסף של משתנים שאפשר להעביר אותם ולהחזיר אותם מפונקציה בתור פרמטר אחד

        public void Run()
        {
            int id;
            string name;


            (int id, string fname, string lname) var1;

            var1 = (123, "Moshe", "Choen");

            var newPerson = CreatePerson();


        }
        public (int id, string fname, string lname) CreatePerson()
        {
            int id = 12;
            string fname = "Moshe";
            string lname = "Choen";
            (int id, string fname, string lname) var1;
            var1.id = id;
            var1 = (id, fname, lname);
            return var1;
        }
    }

    }

