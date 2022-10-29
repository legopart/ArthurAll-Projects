using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{


    //Event - מנגנון להפצת הודעות בין פונקציות למחלקות שונות

    internal class _3_Events
    {

        public delegate void TimeOut_func(int time, int id);
        public event TimeOut_func TimeOut_handler;
        public void Run()
        {
            // broadcact events to all listeners
            if (TimeOut_handler != null)
                TimeOut_handler(1200, 9876);
        }

    }

    public class Operate
    {
        _3_Events _3_Events = new _3_Events();
        DB db = new DB();
        UI ui = new UI();
        public void Init()
        {
            // register to broadcast list
            _3_Events.TimeOut_handler += db.UpdateDBAfterTimeout;
            _3_Events.TimeOut_handler += ui.UpdateUIAfterTimeout;

            _3_Events.Run();

            // unregister from broadcast list
            _3_Events.TimeOut_handler -= ui.UpdateUIAfterTimeout;
            _3_Events.Run();

        }

    }


    public class DB
    {
        public void UpdateDBAfterTimeout(int time, int id)
        {

        }
    }

    public class UI
    {
        public void UpdateUIAfterTimeout(int time, int id)
        {

        }

    }

}
