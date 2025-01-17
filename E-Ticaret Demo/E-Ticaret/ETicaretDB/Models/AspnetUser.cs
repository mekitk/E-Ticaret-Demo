﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class AspnetUser
    {
        public AspnetUser()
        {
            AspnetPersonalizationPerUsers = new HashSet<AspnetPersonalizationPerUser>();
            AspnetUsersInRoles = new HashSet<AspnetUsersInRole>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string Password { get; set; }
        public bool? Isadmin { get; set; }

        public virtual AspnetApplication Application { get; set; }
        public virtual AspnetProfile AspnetProfile { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public virtual ICollection<AspnetUsersInRole> AspnetUsersInRoles { get; set; }
    }
}
