using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    public interface INumber
    {
        bool ishigher();
        bool iscorrect();
        int generateNumber();
    }
}
