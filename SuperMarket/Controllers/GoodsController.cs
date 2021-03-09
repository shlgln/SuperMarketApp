using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models.Dtos.GoodDto;
using SuperMarket.Services.GoodServices;
using System.Collections.Generic;

namespace SuperMarket.Controllers
{
    [ApiController,Route("api/goods")]
    public class GoodsController : Controller
    {
        private readonly GoodService _goodService;
        public GoodsController(GoodService goodService)
        {
            _goodService = goodService;
        }

        [HttpPost]
        public void Add(AddGoodDto dto)
        {
            _goodService.AddGood(dto);
        }

        [HttpGet]
        public IList<GetGoodDto> GetAll()
        {
            return _goodService.GetAllGoods();
        }
    }
}
