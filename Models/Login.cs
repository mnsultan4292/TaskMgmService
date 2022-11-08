using System;
using System.Collections.Generic;

namespace TaskMgmService.Models
{
    public partial class Login
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int UserId { get; set; }

        public virtual Registration User { get; set; } = null!;
    }
}
