using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.UnitOfWorks
{
    public interface UnitOfWork
    {
        void Complete();
    }
}
