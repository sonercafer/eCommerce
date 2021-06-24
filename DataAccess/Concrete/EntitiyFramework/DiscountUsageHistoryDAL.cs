﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using eCommerce.Core.DataAccess;
using eCommerce.Core.DataAccess.EntitiyFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public  class DiscountUsageHistoryDAL : EfEntityRepositoryBase<DiscountUsageHistory, eCommerceContext>, IDiscountUsageHistoryDAL
    {
        public DiscountUsageHistoryDAL(eCommerceContext context) : base(context)
        {
        }
    }
}
