using DigitalWorld.DAL.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Model
{
    public class ProductSize
    {
        public int Id { get; set; }
        public string Dimension { get; set; }
        public int Weight { get; set; }
        public ColourType ColourType { get; set; }

        public ICollection<PlayStation> PlayStations { get; set; }
        public ICollection<GamePad> GamePads { get; set; }
    }
}
