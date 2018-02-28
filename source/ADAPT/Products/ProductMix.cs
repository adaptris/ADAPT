using AgGateway.ADAPT.ApplicationDataModel.Representations;
using System;

namespace AgGateway.ADAPT.ApplicationDataModel.Products
{
    [Obsolete("Use MixProduct from now on")]
    public class ProductMix : Product
    {
        public NumericRepresentationValue TotalQuantity { get; set; }

        public bool IsTemporary { get; set; }

        public bool IsHotMix { get; set; }
    }
}
