using SuperMarket.Models.Dtos.GoodCategoryDto;
using SuperMarket.Models.Entities;
using SuperMarket.Models.Exceptions;
using SuperMarket.Repositories.RepositoryGoodCategory;
using SuperMarket.UnitOfWorks;
using System;
using System.Collections.Generic;

namespace SuperMarket.Services.GoodCategoryServices
{
    public class AppGoodCategoryService: GoodCategoryService
    {
        private readonly GoodCategoryRepository repository;
        private readonly UnitOfWork unitOfWork;
        public AppGoodCategoryService(GoodCategoryRepository repository, UnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public void AddGoodCategory(string Title)
        {
            if (GoodCaterotyDublicate(Title))
            {
                throw new GoodCategoryTitleCantBeDuplicatedExcption();
            }

            var goodCategory = new GoodCategory
            {
                Title = Title
            };

            repository.AddGoodCategory(goodCategory);
            unitOfWork.Complete();
        }
        private bool GoodCaterotyDublicate(string Title)
        {
            return repository.GoodCaterotyDublicate(Title);
        }

        public IList<GetGoodCategoryDto> GetAllGategories()
        {
            return repository.GetAllGategories();
        }
        public void DeleteGoodCategory(int id)
        {
            var goodCategory = GetCategory(id);
            if (goodCategory == null)
                throw new Exception();

            repository.DeleteGoodCategory(id);
            unitOfWork.Complete();
        }
        public void UpdateGoodCategory(int id, UpdateGoodCategoryDto dto)
        {
            var category = GetCategory(id);
            if (category == null)
                throw new Exception();

            category.Title = dto.Title;

            unitOfWork.Complete();
        }
        private GoodCategory GetCategory(int id)
        {
            return repository.GetCategory(id);
        }
    }
}
