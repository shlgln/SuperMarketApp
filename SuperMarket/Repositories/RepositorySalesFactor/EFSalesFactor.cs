using SuperMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Repositories.RepositorySalesFactor
{
    public class EFSalesFactor:SalesFactorRepository
    {
        private readonly ApplicationContex _context;
        public EFSalesFactor(ApplicationContex context)
        {
            _context = context;
        }

        public void Add(SaleFactors salesFactor)
        {
            _context.Add(salesFactor);
        }

        public List<SaleFactors> GetAll()
        {
            return _context.SaleFactors.ToList();
        }
    }
}
