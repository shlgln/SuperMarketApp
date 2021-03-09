using SuperMarket.Models.Dtos.SalesFactorDto;
using SuperMarket.Repositories.RepositoryGood;
using SuperMarket.Repositories.RepositorySalesFactor;
using SuperMarket.UnitOfWorks;
using System;
using System.Collections.Generic;

namespace SuperMarket.Services.SelesFactorServices
{
    public class AppSalesFactorService: SalesFactorService
    {
        private readonly SalesFactorRepository _Salesrepository;
        private readonly GoodRepository _goodRepository;
        private readonly UnitOfWork _unitOfWork;

        public AppSalesFactorService(SalesFactorRepository Salesrepository, GoodRepository goodRepository, UnitOfWork unitOfWork)
        {
            _Salesrepository = Salesrepository;
            _unitOfWork = unitOfWork;
            _goodRepository = goodRepository;
        }
        public void Add(AddSalesFactorDto dto)
        {
            var good = _goodRepository.GetGoodByCode(dto.GoodCode);

            if (good == null)
                throw new Exception();

            if (good.Count < dto.GoodCount)
                throw new Exception();

            var salesFactor = new AddSalesFactorDto
            {
                GoodCount = dto.GoodCount,
                SaleDate = DateTime.Now,
                GoodCode = dto.GoodCode
            };
            good.Count -= dto.GoodCount;

            _Salesrepository.Add(salesFactor);

            _unitOfWork.Complete();
        }

        public IList<GetSalesFactorDto> GetAll()
        {
            return _Salesrepository.GetAll();
        }
    }
}
