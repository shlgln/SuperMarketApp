using SuperMarket.Models.Dtos.SalesFactorDto;
using System.Collections.Generic;

namespace SuperMarket.Repositories.RepositorySalesFactor
{
    public interface SalesFactorRepository
    {
        void Add(AddSalesFactorDto salesFactor);

        List<GetSalesFactorDto> GetAll();
    }
}
