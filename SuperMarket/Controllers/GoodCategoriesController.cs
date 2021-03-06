using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;
using SuperMarket.Models.Dtos;
using SuperMarket.Models.Exceptions;
using SuperMarket.Repositories.RepositoryGoodCategory;
using SuperMarket.UnitOfWorks;
using System.Collections.Generic;

namespace SuperMarket.Controllers
{
    [ApiController]
    [Route("api/good-categories")]
    public class GoodCategoriesController : Controller
    {
        private readonly GoodCategoryRepository _goodCategoryRepository;
        private readonly UnitOfWork _unitOfWork;

        public GoodCategoriesController(GoodCategoryRepository goodCategoryRepository, UnitOfWork unitOfWork)
        {
            _goodCategoryRepository = goodCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public void Add([FromBody]string Title)
        {
            if(_goodCategoryRepository.GoodCaterotyDublicate(Title))
            {
                throw new GoodCategoryTitleCantBeDuplicatedExcption();
            }

            var goodCategory = new GoodCategory
            {
                Title = Title
            };

            _goodCategoryRepository.Add(goodCategory);
            _unitOfWork.Complete();
        }

        [HttpGet]
        public IList<GetGoodCategoryDto> GetAll()
        {
            return _goodCategoryRepository.GetAll();
        }

        [HttpPut("{id}")]
        public void Update(int id, UpdateGoodCategoryDto dto)
        {
            _goodCategoryRepository.UpdateGoodCategory(id, dto);
            _unitOfWork.Complete();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _goodCategoryRepository.DeleteGoodCategory(id);

            _unitOfWork.Complete();
        }
    }
}
