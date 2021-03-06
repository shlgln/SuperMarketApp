using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Models.Dtos.GoodEntryDto
{
    public class AddGoodEntryDto
    {
        public string GoodCode { get; set; }
        public DateTime EntryDate { get; set; }
        public int GoodCount { get; set; }
    }
}
