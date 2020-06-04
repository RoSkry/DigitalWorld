using DigitalWorld.DAL.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Model
{
    public class PlayStation : BaseEntity
    {
        public string Type { get; set; }
        public HardDiskType HardDiskType { get; set; }
        public string CPU { get; set; }
        public string CPUModel { get; set; }
        public float CPUFrequency { get; set; }
        public int CoreCount { get; set; }
        public string GraphicCore { get; set; }
        public string VideoMemoryVolume { get; set; }
        public int RAMVolume { get; set; }
        public string RAMType { get; set; }
        public int InternalMemoryVolume { get; set; }
        public string Сomplectation { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductSizeId { get; set; }
        public ProductSize ProductSize { get; set; }
    }
}
