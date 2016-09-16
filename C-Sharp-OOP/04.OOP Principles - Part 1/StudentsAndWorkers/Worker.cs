using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    internal class Worker : Human
    {
        private uint weekSalary;
        private uint workHoursPerDay;

        public Worker(string firstName, string lastName, uint weekSalary, uint workHoursPerDay) :
            base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public uint WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                this.weekSalary = value;
            }
        }

        public uint WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                this.workHoursPerDay = value;
            }
        }

        public uint MoneyPerHour()
        {
            uint moneyPerHour = 0;
            uint workHoursPerWeek = 40;

            moneyPerHour = this.WeekSalary / workHoursPerWeek;

            return moneyPerHour;
        }

    }
}
