﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class AspnetSchemaVersion
    {
        public string Feature { get; set; }
        public string CompatibleSchemaVersion { get; set; }
        public bool IsCurrentVersion { get; set; }
    }
}
