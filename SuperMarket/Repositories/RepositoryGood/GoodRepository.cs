using SuperMarket.Models;
using SuperMarket.Models.Dtos;
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
 