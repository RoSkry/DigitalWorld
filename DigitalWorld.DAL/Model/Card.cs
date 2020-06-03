using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Model
{
    public class Card : BaseEntity
    {
        public string Type { get; set; }
        public string Information { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
