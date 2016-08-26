using Cars.Contracts;
using Cars.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Tests.Moq
{
    public class CarsRepositoryChild : CarsRepository, ICarsRepository
    {
        public CarsRepositoryChild(IDatabase database) : base (database)
        {
        }

        public IDatabase GetData()
        {
            return base.Data;
        }
    }
}
