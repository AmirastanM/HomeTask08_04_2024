﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    internal abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
