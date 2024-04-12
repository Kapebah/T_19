using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class PersonalComputer : ISwitchable
    {
        public bool Off() => false;

        public bool On() => true;
    }
}
