using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class Call
    {
        private DateTime date;
        private string dialled;
        private double duration;

        public Call(string dialled, double duration)
        {
            this.Date = DateTime.Now;
            this.Dialled = dialled;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = DateTime.Now;
            }
        }

        public string Dialled
        {
            get
            {
                return this.dialled;
            }
            set
            {
                this.dialled = value;
            }
        }

        public double Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
    }
}
