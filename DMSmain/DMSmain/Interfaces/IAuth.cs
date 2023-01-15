using DMSmain.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.Interfaces
{
    internal interface IAuth
    {
        MUser Authenticate(MUser inputUser);
    }
}
