using SuperMarket.Models.Dtos.GoodDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;

namespace SuperMarket.Repositories.RepositoryGood
{
    public interface GoodRepository
    {
        Good GetGoodByCode(string code);
        bool IsGoodCount(string code); 
        int GetGoodCount(string code);
        void Add(Good good);
        List<GetGoodDto> GetAllGoods();
    }
}
 