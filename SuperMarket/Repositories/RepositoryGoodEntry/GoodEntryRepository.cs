using SuperMarket.Models;
using SuperMarket.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Repositories.RepositoryGoodEntry
{
    public interface GoodEntryRepository
    {
        void Add(GoodEntry goodEntry);
        List<GoodEntryDto> GetAllGoodEntry();
    }
}
