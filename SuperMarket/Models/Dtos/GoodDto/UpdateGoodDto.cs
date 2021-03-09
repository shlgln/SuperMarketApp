using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Models.Dtos.GoodDto
{
    public class UpdateGoodDto
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
