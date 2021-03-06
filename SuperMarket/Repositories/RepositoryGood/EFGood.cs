using SuperMarket.Models;
using SuperMarket.Models.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarket.Repositories.RepositoryGood
{
    public class EFGood : GoodRepository
    {
        private readonly ApplicationContex _context;
        public EFGood(ApplicationContex contex)
        {
            _context = contex;
        }

        public void Add(Good good)
        {
            _context.Add(good);
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
            return _context.Goods.Where(g => g.Code == code).FirstOrDefault();
        }

        public int GetGoodCount(string code)
        {
            return _context.Goods.SingleOrDefault().Count;

        }
        public bool IsGoodCount(string code)
        {
            return _context.Goods.Any(_ => _.Code == code);
        }
    }
}
