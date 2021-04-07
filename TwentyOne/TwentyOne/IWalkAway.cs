using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    interface IWalkAway //naming an interface always begins with an "I"
    {
        void WalkAway(player player); //you can inherit as many interfaces as you want, method WalkAway, everything is public in interface
    }
}
