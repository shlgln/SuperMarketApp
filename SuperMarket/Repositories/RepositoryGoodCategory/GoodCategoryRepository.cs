using SuperMarket.Models.Dtos.GoodCategoryDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;

namespace SuperMarket.Repositories.RepositoryGoodCategory
{
    public interface GoodCategoryRepository
    {
        void AddGoodCategory(string Title);
        IList<GetGoodCategoryDto> GetAllGategories();
        void DeleteGoodCategory(int id);
        bool GoodCaterotyDublicate(string Title);
        GoodCategory GetCategory(int id);
    }
}
