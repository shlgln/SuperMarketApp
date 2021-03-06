using SuperMarket.Models;
using SuperMarket.Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.UnitOfWorks
{
    public class EFUnitOfWork : UnitOfWork
    {
        private readonly ApplicationContex _context;
        public EFUnitOfWork(ApplicationContex context)
        {
            _context = context;
        }
        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
