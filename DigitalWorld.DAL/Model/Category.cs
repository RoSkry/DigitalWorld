using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Model
{
    public class Category:BaseEntity
    {
        public ICollection<Game> Games { get; set; }
        public ICollection<GamePad> GamePads { get; set; }
        public ICollection<PlayStation> PlayStations { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}
