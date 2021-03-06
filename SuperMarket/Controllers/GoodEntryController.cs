using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models.Dtos.GoodEntryDto;
using SuperMarket.Models.Entities;
using SuperMarket.Repositories.RepositoryGood;
using SuperMarket.Repositories.RepositoryGoodEntry;
using SuperMarket.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarket.Controllers
{
    [ApiController, Route("api/goodsEntry")]
    public class GoodEntryController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly GoodEntryRepository _goodEntryRepository;

        private readonly GoodRepository _goodRepository;

        public GoodEntryController(UnitOfWork unitOfWork, GoodEntryRepository goodEntryRepository)
        {
            _unitOfWork = unitOfWork;
            _goodEntryRepository = goodEntryRepository;
        }

        [HttpPost]
        public void AddGoodEntry([FromBody]AddGoodEntryDto dto)
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
            _goodEntryRepository.Add(goodEntry);
            _unitOfWork.Complete();
        }

        [HttpGet]
        public List<GetGoodEntryDto> GetAll()
        {
            return _goodEntryRepository.GetAllGoodEntry();
            
        }
    }
}
