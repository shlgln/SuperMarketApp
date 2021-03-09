using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models.Dtos.SalesFactorDto;
using SuperMarket.Services.SelesFactorServices;
using System.Collections.Generic;

namespace SuperMarket.Controllers
{
    [ApiController]
    [Route("api/sale-factor")]
    public class SalesFactorController : Controller
    {
        private readonly SalesFactorService _salesFactorService;
        public SalesFactorController(SalesFactorService salesFactorService)
        {
            _salesFactorService = salesFactorService;
        }

        [HttpPost]
        public void AddSalesFacror([FromBody] AddSalesFactorDto dto)
        {
            _salesFactorService.Add(dto);
        }

        [HttpGet]
        public IList<GetSalesFactorDto> GetAllSaleSFactors()
        {
            return _salesFactorService.GetAll();
        }
    }
}
