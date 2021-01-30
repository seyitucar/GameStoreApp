using GameStoreApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal DiscountRate { get; set; }

    }
}
