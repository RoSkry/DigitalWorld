using DigitalWorld.DAL.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Model
{
    public class Game : BaseEntity
    {
        public GenreType GenreType { get; set; }
        public string Localization { get; set; }
        public int AgeLimit { get; set; }
        public string DevCompany { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
