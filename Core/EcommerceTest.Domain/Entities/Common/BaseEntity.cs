﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceTest.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid ID { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
