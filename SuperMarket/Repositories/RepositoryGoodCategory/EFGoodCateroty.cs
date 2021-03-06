using SuperMarket.Models;
using SuperMarket.Models.DBContext;
using SuperMarket.Models.Dtos;
using SuperMarket.Models.Dtos.GoodCategoryDto;
using SuperMarket.Models.Entities;
using System;
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

        public void Add(GoodCategory goodCategory)
        {
            _context.Add(goodCategory);
        }

        public void DeleteGoodCategory(int id)
        {
            var goodCategory = GetCategoryById(id);
            _context.GoodCategories.Remove(goodCategory);
        }

        public IList<GetGoodCategoryDto> GetAll()
        {
            //return _context.GoodCategories.Select
            //      (_ => new GetGoodCategoryDto
            //      {
            //          Id = _.Id,
            //          Title = _.Title
            //      }).ToList();
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

        private GoodCategory GetCategoryById(int id)
        {
            return _context.GoodCategories.Find(id);
        }

        public bool GoodCaterotyDublicate(string Title)
        {
            return _context.GoodCategories.Any(_ => _.Title == Title);
        }

        public void UpdateGoodCategory(int id, UpdateGoodCategoryDto dto)
        {
            var category = GetCategoryById(id);
            if (category == null)
                throw new Exception();

            category.Title = dto.Title;
        }
    }
}
