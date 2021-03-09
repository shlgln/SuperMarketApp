using SuperMarket.Models.Dtos.GoodDto;
using SuperMarket.Models.Entities;
using SuperMarket.Models.Exceptions;
using SuperMarket.Repositories.RepositoryGood;
using SuperMarket.UnitOfWorks;
using System.Collections.Generic;

namespace SuperMarket.Services.GoodServices
{
    public class AppGoodService : GoodService
    {
        private readonly GoodRepository repository;
        private readonly UnitOfWork unitOfWork;

        public AppGoodService(GoodRepository repository, UnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void AddGood(AddGoodDto dto)
        {
            if (IsGoodCode(dto.Code))
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

            repository.AddGood(good);

            unitOfWork.Complete();
        }

        public bool IsGoodCode(string code)
        {
            return repository.IsGoodsExistsByCode(code);
        }

        public IList<GetGoodDto> GetAllGoods()
        {
            return repository.GetAllGoods();
        }
    }
}
