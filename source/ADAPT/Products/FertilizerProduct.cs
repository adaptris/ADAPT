using System;

namespace AgGateway.ADAPT.ApplicationDataModel.Products
{
    [Obsolete("Use CropNutritionProduct from now on")]
    public class FertilizerProduct : Product
    {
        public bool IsManure { get; set; }
    }
}
