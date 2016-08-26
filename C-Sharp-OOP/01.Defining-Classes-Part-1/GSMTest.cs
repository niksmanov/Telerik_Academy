using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class GSMTest
    {
        public static void Test()
        {
            GSM[] devices = 
            {
             new GSM("Galaxy", "Samsung", 800, "Yakamoto", new Battery(BatteryType.LiIon, 400, 10), new Display(5.2, 16000000)),
             new GSM("E72", "Nokia", 200, "Takira", new Battery(BatteryType.NiMH, 800, 20), new Display(4.0, 256000)),
             GSM.IPhone
            };

            foreach (GSM device in devices)
            {
                Console.WriteLine(device);
            }
        }
    }
}
