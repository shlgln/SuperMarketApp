using SuperMarket.Models.Dtos.GoodEntryDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;

namespace SuperMarket.Repositories.RepositoryGoodEntry
{
    public interface GoodEntryRepository
    {
        void AddGoodEntry(GoodEntry goodEntry);
        List<GetGoodEntryDto> GetAllGoodEntry();
    }
}
