using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models.Dtos.GoodEntryDto;
using SuperMarket.Services.GoodEntryServices;
using System.Collections.Generic;

namespace SuperMarket.Controllers
{
    [ApiController, Route("api/goodsEntry")]
    public class GoodEntryController : Controller
    {
        private readonly GoodEntryService _service;

        public GoodEntryController(GoodEntryService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddGoodEntry([FromBody]AddGoodEntryDto dto)
        {
            _service.AddGoodEntry(dto);
        }

        [HttpGet]
        public IList<GetGoodEntryDto> GetAll()
        {
            return _service.GetAllGoodEntry();
            
        }
    }
}
