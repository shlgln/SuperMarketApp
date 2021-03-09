using SuperMarket.Models.Dtos.GoodDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;

namespace SuperMarket.Repositories.RepositoryGood
{
    public interface GoodRepository
    {
        void AddGood(Good good);
        List<GetGoodDto> GetAllGoods();
        bool IsGoodCode(string code);
        bool IsGoodsExistsByCode(string code);
        Good GetGoodByCode(string code);
    }
}
 