using SuperMarket.Models.DBContext;
using SuperMarket.Models.Dtos.GoodDto;
using SuperMarket.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarket.Repositories.RepositoryGood
{
    public class EFGoodRepository : GoodRepository
    {
        private readonly ApplicationContex _context;

        public EFGoodRepository(ApplicationContex contex)
        {
            _context = contex;
        }

        public void AddGood(Good good)
        {
            _context.Add(good);
        }

        public bool IsGoodCode(string code)
        {
            return _context.Goods.Any(_ => _.Code == code);
        }
        public List<GetGoodDto> GetAllGoods()
        {
            return _context.Goods.Select
                (_ => new GetGoodDto
                {
                    Code = _.Code,
                    CategoryId = _.CategoryId,
                    Title = _.Title,
                    Status = _.Status,

                }).ToList();
        }
        public Good GetGoodByCode(string code)
        {
            return _context.Goods.Find(code);
        }

        public bool IsGoodsExistsByCode(string code)
        {
            return _context.Goods.Any(_ => _.Code == code);
        }
    }
}
