using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;
using SuperMarket.Models.Dtos;
using SuperMarket.Repositories.RepositoryGood;
using SuperMarket.Repositories.RepositorySalesFactor;
using SuperMarket.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarket.Controllers
{
    [ApiController]
    [Route("api/sale-factor")]
    public class SalesFactorController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly SalesFactorRepository _saleFactorRepository;
        private readonly GoodRepository _goodRepository;


        public SalesFactorController(UnitOfWork unitOfWork, SalesFactorRepository salesFactorRepository, GoodRepository goodRepository)
        {
            _unitOfWork = unitOfWork;
            _saleFactorRepository = salesFactorRepository;
            _goodRepository = goodRepository;
        }

        [HttpPost]
        public void AddSalesFacror([FromBody] AddSalesFactorDto dto)
        {
            var good = _goodRepository.GetGoodByCode(dto.GoodCode);

            if (good == null)
                throw new Exception();

            if (good.Count < dto.GoodCount)
                throw new Exception();

            var salesFactor = new SaleFactors
            {
                GoodCount = dto.GoodCount,
                SalesDate = DateTime.Now,
                GoodCode = dto.GoodCode
            };
            good.Count -= dto.GoodCount;
            _saleFactorRepository.Add(salesFactor);
            _unitOfWork.Complete();
        }

        [HttpGet]
        public List<SaleFactors> GetAllSaleSFactors()
        {
            return _saleFactorRepository.GetAll();
        }
    }
}
