using SuperMarket.Models.DBContext;
using SuperMarket.Models.Dtos.SalesFactorDto;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarket.Repositories.RepositorySalesFactor
{
    public class EFSalesFactor : SalesFactorRepository
    {
        private readonly ApplicationContex _context;
        public EFSalesFactor(ApplicationContex context)
        {
            _context = context;
        }

        public void Add(AddSalesFactorDto salesFactor)
        {
            _context.Add(salesFactor);
        }

        public List<GetSalesFactorDto> GetAll()
        {
            var query = from s in _context.SaleFactors
                        join g in _context.Goods on s.GoodCode equals g.Code
                        select new GetSalesFactorDto
                        {
                            Id = s.Id,
                            Title = g.Title,
                            GoodCode = s.GoodCode,
                            GoodCount = s.GoodCount,
                            SaleDate = s.SalesDate
                        };
            return query.ToList();
        }
    }
}
