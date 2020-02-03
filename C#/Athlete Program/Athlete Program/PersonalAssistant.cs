using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Program
{
    class PersonalAssistant : Professional
    {
        public override ProfType Type
        {
            get
            {
                return base.Type;
            }
        }

        public PersonalAssistant() : base()
        {
        }

        public PersonalAssistant(string strName, Athlete athEmployer)
                : base(strName, ProfType.PersonalAssistant, 0.03m, athEmployer)
        {
        }
    }
}
