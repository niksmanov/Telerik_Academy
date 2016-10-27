using Adapter.Contracts;
using Adapter.Models;

namespace Adapter
{
    class StartUp
    {
        static void Main()
        {
            ITarget target = new EmployeeAdapter();
            BillingSystem client = new BillingSystem(target);
            client.ShowEmployeeList();
        }
    }
}
