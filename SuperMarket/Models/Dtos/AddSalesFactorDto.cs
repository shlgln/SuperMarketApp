using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Models.Dtos
{
    public class AddSalesFactorDto
    {
        public string GoodCode { get; set; }
        public DateTime SaleDate { get; set; }
        public int GoodCount { get; set; }
    }
}
