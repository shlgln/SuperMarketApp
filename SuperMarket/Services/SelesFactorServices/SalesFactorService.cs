using SuperMarket.Models.Dtos.SalesFactorDto;
using System.Collections.Generic;

namespace SuperMarket.Services.SelesFactorServices
{
    public interface SalesFactorService
    {
        public void Add(AddSalesFactorDto dto);

        public IList<GetSalesFactorDto> GetAll();
    }
}