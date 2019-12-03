using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpANumber
{
    interface IMakeItUp
    {
        List<string> getAnswers(int[] numberList, int solution);
    }
}
