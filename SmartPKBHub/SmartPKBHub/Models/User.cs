using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPKBHub.Models
{
    public partial class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
