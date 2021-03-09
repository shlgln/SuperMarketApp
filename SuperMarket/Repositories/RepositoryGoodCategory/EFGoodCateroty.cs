using SuperMarket.Models.DBContext;
using SuperMarket.Models.Dtos.GoodCategoryDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarket.Repositories.RepositoryGoodCategory
{
    public class EFGoodCateroty : GoodCategoryRepository
    {
        private readonly ApplicationContex _context;

        public EFGoodCateroty(ApplicationContex context)
        {
            _context = context;
        }

        public void AddGoodCategory(string Title)
        {
            _context.Add(Title);
        }
        public bool GoodCaterotyDublicate(string Title)
        {
            return _context.GoodCategories.Any(_ => _.Title == Title);
        }

        public IList<GetGoodCategoryDto> GetAllGategories()
        {
            var query = from a in _context.Goods
                        join p in _context.GoodCategories on a.CategoryId equals p.Id
                        where p.Id == a.CategoryId
                        select new GetGoodCategoryDto
                        {
                            Id = a.Id,
                            Title = p.Title,
                            goods =p.Goods.Select(m=>m.Title).ToList(),
                        };  
            return query.ToList();
        }
        public void DeleteGoodCategory(int id)
        {
            var goodCategory = GetCategory(id);

            _context.GoodCategories.Remove(goodCategory);
        }
        public GoodCategory GetCategory(int id)
        {
            return _context.GoodCategories.Find(id);
        }

    }
}
