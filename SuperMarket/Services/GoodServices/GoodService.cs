using SuperMarket.Models.Dtos.GoodDto;
using System.Collections.Generic;

namespace SuperMarket.Services.GoodServices
{
    public interface GoodService
    {
        void AddGood(AddGoodDto dto);
        bool IsGoodCode(string code);
        IList<GetGoodDto> GetAllGoods();
    }
}
