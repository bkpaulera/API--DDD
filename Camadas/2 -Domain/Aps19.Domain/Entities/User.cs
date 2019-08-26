using System;
using System.Collections.Generic;
using System.Text;

namespace Aps19.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsActive { get; set; }
    }
}
