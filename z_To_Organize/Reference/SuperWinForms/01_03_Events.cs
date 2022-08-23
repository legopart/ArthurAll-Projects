using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperWinForms
{






    public class OperateClass
    {
        EventInit eventInit = new EventInit(0, 1, 2);
        EventClass1 eventClass1 = new EventClass1();
        EventClass2 eventClass2 = new EventClass2();
        EventClass3 eventClass3 = new EventClass3();

        public void Init()
        {
            // register to broadcast list
            eventInit.ClassEvent += eventClass1.Class1Add;
            eventInit.ClassEvent += eventClass2.Class2Mult;

            eventInit.Run();

            // unregister from broadcast list
            /* *
            meet1_Events.TimeOut_handler -= ui.UpdateUIAfterTimeout;
            meet1_Events.Run();
            /* */

        }

    }

    public class EventInit
    {
        private double initInc = 1;
        public static string str = "" + 0;
        public static double inc = 0;
        public static double value = 0;
        public static double incReset = 0;
        public static double valueReset = 0;

        private double _inc;
        private double _value;
        public EventInit(double incSet, double valueStart, double valueSet) {
            str = "Event Order: " + valueStart;
            inc = initInc;
            incReset = initInc;
            _inc = incSet;
            _value = valueSet;
            valueReset = valueStart;
            value = valueStart;
        }

        public delegate void DeligateFunc(double inc, double value);
        public event DeligateFunc? ClassEvent;
        public void Run()
        {
            // broadcact events to all listeners
            if (ClassEvent != null)
                ClassEvent(_inc, _value);
        }
    }
    public class EventClass1
    {
        public void Class1Add(double inc, double value)
        {
            EventInit.inc += inc;
            EventInit.value += value;
            EventInit.str += " +" + value;
        }
    }
    public class EventClass2
    {
        public void Class2Mult (double inc, double value)
        {
            EventInit.inc += inc;
            EventInit.value *= value;
            EventInit.str += " *" + value;

        }
    }
    public class EventClass3
    {
        public void Class3Delete(double inc, double value)
        {
            EventInit.inc += inc;
            EventInit.value -= value;
            EventInit.str += " -" + value;
        }
    }

    public class EventClassReset
    {
        public void ClassReset(double inc, double value)
        {
            EventInit.inc = EventInit.incReset;
            EventInit.value = EventInit.valueReset;
            EventInit.str = "Event Order: " + EventInit.valueReset;
        }
    }


}
