using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Models.Entities
{
    public class GoodCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Good> Goods { get; set; }
    }
}
