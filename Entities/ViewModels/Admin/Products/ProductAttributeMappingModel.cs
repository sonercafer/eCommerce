namespace Entities.ViewModels.Admin
{
    using Entities.ViewModels.Admin.Products;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class ProductAttributeMappingModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int? DisplayOrder { get; set; }
        public string DefaultValue { get; set; }
        public ProductAttributeModel ProductAttribute { get; set; }
        public IList<ProductAttributeValueModel> ProductAttributeValue { get; set; }
        public IList<ProductAttributeMappingModel> ProductAttributeMappingList { get; set; }
    }
}
