using GameStoreApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
    }
}
