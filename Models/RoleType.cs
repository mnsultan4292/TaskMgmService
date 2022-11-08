using System;
using System.Collections.Generic;

namespace TaskMgmService.Models
{
    public partial class RoleType
    {
        public RoleType()
        {
            Registrations = new HashSet<Registration>();
        }

        public int RoleId { get; set; }
        public string RoleType1 { get; set; } = null!;

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
