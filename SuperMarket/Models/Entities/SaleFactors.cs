using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Models.Entities
{
    public class GetSalesFactorDtors
    {
        public int Id { get; set; }
        public string GoodCode { get; set; }
        public DateTime SalesDate { get; set; }
        public int GoodCount { get; set; }
    }
}
