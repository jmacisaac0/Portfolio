using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Program
{
    class Lawyer : Professional
    {
        public override ProfType Type
        {
            get
            {
                return base.Type;
            }
        }

        public Lawyer() : base()
        {
        }

        public Lawyer(string strName, Athlete athEmployer)
                : base(strName, ProfType.Lawyer, 0.10m, athEmployer)
        {
        }
    }
}
