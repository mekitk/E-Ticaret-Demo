﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class VwAspnetUsersInRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
