using System;
using System.Collections.Generic;

namespace TaskMgmService.Models
{
    public partial class RoleType
    {
        public RoleType()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleType1 { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
