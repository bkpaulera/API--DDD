using System;
using System.Collections.Generic;
using System.Text;

namespace Aps19.Domain.Entities
{
    public class User:BaseEntity
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Passaword { get; set; }
        public bool Active { get; set; }
    }
}
