using SuperMarket.Models.DBContext;
using SuperMarket.Models.Dtos.GoodEntryDto;
using SuperMarket.Models.Entities;
using SuperMarket.Repositories.RepositoryGood;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarket.Repositories.RepositoryGoodEntry
{
    public class EFGoodEntry : GoodEntryRepository
    {
        private readonly ApplicationContex _context;
        private readonly GoodRepository _goodRepository;

        public EFGoodEntry(ApplicationContex context, GoodRepository goodRepository)
        {
            _context = context;
            _goodRepository = goodRepository;
        }

        public void AddGoodEntry(GoodEntry goodEntry)
        {
            _context.Add(goodEntry);
        }

        public List<GetGoodEntryDto> GetAllGoodEntry()
        {
            var query = from a in _context.GoodEntries
                        join p in _context.Goods on a.GoodCode equals p.Code
                        join c in _context.GoodCategories on p.CategoryId equals c.Id
                        select new GetGoodEntryDto
                        {
                            Id = a.Id,
                            GoodTitle = p.Title,
                            CategoryTitle = c.Title,
                            GoodCode = p.Code
                        };

            return query.ToList();
        }
    }
}
