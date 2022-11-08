﻿using System;
using System.Collections.Generic;

namespace TaskMgmService.Models
{
    public partial class Registration
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public string PhoneNo { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual RoleType Role { get; set; } = null!;
    }
}
