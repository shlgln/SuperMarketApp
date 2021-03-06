using SuperMarket.Models;
using SuperMarket.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Repositories.RepositoryGoodCategory
{
    public interface GoodCategoryRepository
    {
        public bool GoodCaterotyDublicate(string Title);
        void Add(GoodCategory goodCategory);
        IList<GetGoodCategoryDto> GetAll();
        void DeleteGoodCategory(int id);
        void UpdateGoodCategory(int id, UpdateGoodCategoryDto dto);
    }
}
