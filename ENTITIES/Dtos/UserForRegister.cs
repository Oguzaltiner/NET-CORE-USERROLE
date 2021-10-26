using CORE.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITIES.Dtos
{
    public class UserForRegister : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
