using SuperMarket.Models.Dtos.GoodCategoryDto;
using System.Collections.Generic;

namespace SuperMarket.Services.GoodCategoryServices
{
    public interface GoodCategoryService
    {
        public void AddGoodCategory(string Title);
        public IList<GetGoodCategoryDto> GetAllGategories();
        public void DeleteGoodCategory(int id);
        public void UpdateGoodCategory(int id, UpdateGoodCategoryDto dto);
    }
}
