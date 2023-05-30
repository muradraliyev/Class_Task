using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Engineer : Employee
    {
        private double salary;
        public override double Salary
        {

            get => salary;
            set
            {

                if ((value >= 1000))
                {
                    salary = value;
                }

            }

        }
    }
}