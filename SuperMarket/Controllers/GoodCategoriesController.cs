using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models.Dtos.GoodCategoryDto;
using SuperMarket.Services.GoodCategoryServices;
using System.Collections.Generic;

namespace SuperMarket.Controllers
{
    [ApiController]
    [Route("api/good-categories")]
    public class GoodCategoriesController : Controller
    {
        private readonly GoodCategoryService service;
        public GoodCategoriesController(GoodCategoryService service)
        {
            this.service = service;
        }

        [HttpPost]
        public void Add(string Title)
        {
            service.AddGoodCategory(Title);
        }

        [HttpGet]
        public IList<GetGoodCategoryDto> GetAll()
        {
            return service.GetAllGategories();
        }

        [HttpPut]
        public void Update(int id, UpdateGoodCategoryDto dto)
        {
            service.UpdateGoodCategory(id, dto);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            service.DeleteGoodCategory(id);
        }
    }
}
