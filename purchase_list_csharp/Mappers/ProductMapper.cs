using purchase_list_bg.Models;
using purchase_list_csharp.Models.ViewModels;
using System;

namespace purchase_list_csharp.Mappers
{
    public class ProductMapper : AbstractMapper<Product, ProductViewModel>
    {
        private static ProductMapper _productMapper;

        private ProductMapper() {

        }

        public static ProductMapper GetInstance()
        {
            if (_productMapper == null)
            {
                _productMapper = new ProductMapper();
            }

            return _productMapper;
        }

        public override ProductViewModel FromAToB(Product obj)
        {
            return new ProductViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                CreatedById = obj.CreatedBy.Id,
                CreatedByName = obj.CreatedBy.Name,
                CreatedAt = obj.CreatedAt.Value,
                ModifiedAt = obj.ModifiedAt.Value
            };
        }

        public override Product FromBToA(ProductViewModel obj)
        {
            return new Product
            {
                Id = obj.Id,
                Name = obj.Name,
                ModifiedAt = obj.ModifiedAt,
                CreatedAt = obj.CreatedAt
            };
        }
    }
}
