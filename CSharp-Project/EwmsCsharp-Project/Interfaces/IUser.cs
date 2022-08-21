using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Enums;

namespace ewmsCsharp.Interfaces
{
    public interface IUser
    {
        //string Id { get; protected set; } //new rules
        //string Name { get; set; } //new rules
        string Password { get;  set; }
        UserEnums.UserRank Rank { get; set; }

    }
}
