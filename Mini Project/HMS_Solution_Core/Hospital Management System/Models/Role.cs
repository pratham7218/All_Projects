using System;
using System.Collections.Generic;

namespace Hospital_Management_System.models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<UserTable>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<UserTable> Users { get; set; }
    }
}
