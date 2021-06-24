﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO.Category
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; }

        public List<CategoryDTO> SubCategory { get; set; }
    }
}
