using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models.Dtos.GoodDto;
using SuperMarket.Models.Exceptions;
using SuperMarket.Repositories.RepositoryGood;
using SuperMarket.UnitOfWorks;
using System.Collections.Generic;

namespace SuperMarket.Controllers
{
    [ApiController,Route("api/goods")]
    public class GoodsController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly GoodRepository _goodRepository;
        public GoodsController(UnitOfWork unitOf, GoodRepository goodRepository)
        {
            _unitOfWork = unitOf;
            _goodRepository = goodRepository;
        }

        [HttpPost]
        public void Add([FromBody]AddGoodDto dto)
        {
            if(_goodRepository.IsGoodCount(dto.Code))
            {
                throw new GoodCodeCantBeDuplicateException();
            }

            var good = new Good
            {
                Title = dto.Title,
                Code = dto.Code,
                Count = 0,
                CategoryId = dto.CategoryId
            };

           _goodRepository.Add(good);
            _unitOfWork.Complete();
        }

        [HttpGet]
        public List<GetGoodDto> GetAll()
        {
            return _goodRepository.GetAllGoods();
        }
    }
}
