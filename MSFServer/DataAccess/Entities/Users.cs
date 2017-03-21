using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string UsserType { get; set; }
    }
}
