﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class DiscountProduct: BaseEntity
    {

        public int DiscountId { get; set; }

        public int ProductId { get; set; }
    }
}
