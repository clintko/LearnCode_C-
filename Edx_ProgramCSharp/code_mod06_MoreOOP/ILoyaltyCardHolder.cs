using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06_MoreOOP
{
    interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }
        int AddPoints(decimal transcationValue);
        void ResetPoints();
    }
}
