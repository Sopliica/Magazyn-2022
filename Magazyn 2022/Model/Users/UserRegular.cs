using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn_2022.Model.Users
{
    public class UserRegular : AUser
    {
        public override string GetAllInfo()
        {
            return "User Regular Info";
        }
    }
}
