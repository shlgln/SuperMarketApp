using SuperMarket.Models.Dtos.GoodEntryDto;
using SuperMarket.Models.Entities;
using SuperMarket.Models.Exceptions;
using SuperMarket.Repositories.RepositoryGood;
using SuperMarket.Repositories.RepositoryGoodEntry;
using SuperMarket.UnitOfWorks;
using System;
using System.Collections.Generic;

namespace SuperMarket.Services.GoodEntryServices
{
    public class AppGoodEntryService: GoodEntryService
    {
        private readonly GoodEntryRepository _goodEntryRepository;
        private readonly GoodRepository _goodRepository;
        private readonly UnitOfWork _unitOfWork;
        public AppGoodEntryService(GoodEntryRepository goodEntryRepository, GoodRepository goodRepository, UnitOfWork unitOfWork)
        {
            _goodEntryRepository = goodEntryRepository;
            _goodRepository = goodRepository;
            _unitOfWork = unitOfWork;
        }
        public void AddGoodEntry(AddGoodEntryDto dto)
        {
            var good = _goodRepository.GetGoodByCode(dto.GoodCode);

            if (good == null)
                throw new AddGoodEntryException();

            var goodEntry = new GoodEntry
            {
                GoodCount = dto.GoodCount,
                EntryDate = DateTime.Now,
                GoodCode = dto.GoodCode
            };
            good.Count += dto.GoodCount;
            _goodEntryRepository.AddGoodEntry(goodEntry);
            _unitOfWork.Complete();
        }

        public IList<GetGoodEntryDto> GetAllGoodEntry()
        {
            return _goodEntryRepository.GetAllGoodEntry();
        }
    }
}
