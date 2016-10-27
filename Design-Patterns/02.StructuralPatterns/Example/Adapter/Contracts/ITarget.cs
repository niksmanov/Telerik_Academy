using System.Collections.Generic;

namespace Adapter.Contracts
{
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }
}
