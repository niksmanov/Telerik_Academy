using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class Display
    {
        double size;
        ulong colors;

        public Display(double size, ulong colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public ulong Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                this.colors = value;
            }
        }
    }
}
