using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Program
{
    class Athlete
    {
        private string _strName = "";
        private decimal _decSalary = 0.0m;
        private decimal _remainingSalary = 0.0m;

        public string Name { get => _strName; set => _strName = value; }

        public decimal Salary { get => _decSalary; set => _decSalary = _remainingSalary = value; }

        public decimal RemainingSalary { get => _remainingSalary; set => _remainingSalary = value; }

        public Athlete()
        {
        }

        public Athlete(string strName)
        {
            _strName = strName;
        }

        public Athlete(decimal decSalary)
        {
            _decSalary = decSalary;
            _remainingSalary = decSalary;
        }

        public Athlete(string strName, decimal decSalary)
        {
            _strName = strName;
            _decSalary = decSalary;
            _remainingSalary = decSalary;
        }

    }
}