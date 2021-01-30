using GameStoreApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

    }
}
