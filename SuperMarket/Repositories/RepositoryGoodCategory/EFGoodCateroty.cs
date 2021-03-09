using Microsoft.EntityFrameworkCore;
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

        public void AddGoodCategory(GoodCategory goodCategory)
        {
            _context.Add(goodCategory);
        }
        public bool GoodCaterotyDublicate(string Title)
        {
            return _context.GoodCategories.Any(_ => _.Title == Title);
        }

        public IList<GetGoodCategoryDto> GetAllGategories()
        {
            var query = from p in _context.GoodCategories
                        select new GetGoodCategoryDto
                        {
                            Id = p.Id,
                            Title = p.Title,
                            goods = p.Goods.Select(m => m.Title).ToList(),
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
