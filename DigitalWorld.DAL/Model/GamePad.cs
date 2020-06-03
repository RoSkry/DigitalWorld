using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Model
{
    public class GamePad: BaseEntity
    {
        public string Type { get; set; }
        public int ButtonsCount { get; set; }
        public string Сompatibility { get; set; }
        public string Battery { get; set; }
        public int ProductSizeId { get; set; }
        public ProductSize ProductSize { get; set; }

    }
}
