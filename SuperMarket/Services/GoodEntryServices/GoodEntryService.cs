using SuperMarket.Models.Dtos.GoodEntryDto;
using System.Collections.Generic;

namespace SuperMarket.Services.GoodEntryServices
{
    public interface GoodEntryService
    {
        void AddGoodEntry(AddGoodEntryDto dto);
        IList<GetGoodEntryDto> GetAllGoodEntry();
    }
}