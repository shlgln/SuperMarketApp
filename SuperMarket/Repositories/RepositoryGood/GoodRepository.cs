using SuperMarket.Models.Dtos.GoodDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;

namespace SuperMarket.Repositories.RepositoryGood
{
    public interface GoodRepository
    {
        void AddGood(Good good);
        List<GetGoodDto> GetAllGoods();
        bool IsGoodsExistsByCode(string code);
        Good GetGoodByCode(string code);
        Good GetGoodById(int id);
    }
}
 