﻿using EcommerceTest.Application.Repositories;
using EcommerceTest.Domain;
using EcommerceTest.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceTest.Persistance.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
