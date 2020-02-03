using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Program
{
    class Agent : Professional
    {
        public override ProfType Type
        {
            get
            {
                return base.Type;
            }
        }

        public Agent() : base()
        {
        }

        public Agent(string strName, Athlete athEmployer)
                : base(strName, ProfType.Agent, 0.07m, athEmployer)
        {
        }
    }
}
