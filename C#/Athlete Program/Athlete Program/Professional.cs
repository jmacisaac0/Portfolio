using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Program
{
    class Professional : Athlete
    {
        public enum ProfType { Lawyer, PersonalAssistant, Trainer, Agent };

        private ProfType _profType;
        private decimal _decSalaryPerc;
        private Athlete _athEmployer;


        public virtual ProfType Type { get => _profType; set => _profType = value; }

        public virtual decimal SalaryPerc { get => _decSalaryPerc; set => _decSalaryPerc = value; }

        public Athlete Employer { get => _athEmployer; set => _athEmployer = value; }

        public Professional() : base()
        {
        }

        public Professional(string strName, ProfType profType, decimal decSalaryPerc, Athlete athEmployer) : base(strName)
        {
            _profType = profType;
            _decSalaryPerc = decSalaryPerc;
            _athEmployer = athEmployer;
            this.Salary = _athEmployer.Salary * _decSalaryPerc;
            _athEmployer.RemainingSalary = _athEmployer.RemainingSalary - this.Salary;
        }
    }
}
