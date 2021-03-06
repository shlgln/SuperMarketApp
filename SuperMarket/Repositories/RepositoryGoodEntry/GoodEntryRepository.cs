using SuperMarket.Models.Dtos.GoodEntryDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;

namespace SuperMarket.Repositories.RepositoryGoodEntry
{
    public interface GoodEntryRepository
    {
        void Add(GoodEntry goodEntry);
        List<GetGoodEntryDto> GetAllGoodEntry();
    }
}
