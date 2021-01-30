using GameStoreApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public long IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }
}
