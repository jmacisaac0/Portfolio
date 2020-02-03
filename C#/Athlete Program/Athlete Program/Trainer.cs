using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Program
{
    class Trainer : Professional
    {
        public override ProfType Type
        {
            get
            {
                return base.Type;
            }
        }

        public Trainer() : base()
        {
        }

        public Trainer(string strName, Athlete athEmployer)
                : base(strName, ProfType.Trainer, 0.05m, athEmployer)
        {
        }
    }
}
