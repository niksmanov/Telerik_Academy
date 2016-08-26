using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class GSMCallHistoryTest
    {
        public static void TestCalls()
        {

            GSM gsm = GSM.IPhone;

            gsm.AddCalls("0884657233", 23);
            gsm.AddCalls("0765823476", 5);
            gsm.AddCalls("0856421456", 9);


            double totalPrice = gsm.CallPrice(0.37);

            Console.WriteLine("Total calls duration is: {0}", (totalPrice / 0.37) + " min");
            Console.WriteLine("Total calls price is: {0}", totalPrice + " US" + Environment.NewLine);

            gsm.DeleteCalls(0);
            Console.WriteLine("The longest call from the history was removed!" + Environment.NewLine);

            totalPrice = gsm.CallPrice(0.37);
            Console.WriteLine("Total calls duration is: {0}", (totalPrice / 0.37) + " min");
            Console.WriteLine("Total calls price is: {0}", totalPrice + " US" + Environment.NewLine);

            gsm.ClearCalls();
            Console.WriteLine("GSM call history cleared!");

        }
    }
}
