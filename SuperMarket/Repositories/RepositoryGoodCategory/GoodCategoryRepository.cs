using SuperMarket.Models.Dtos.GoodCategoryDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;

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
