using System;
using System.Collections.Generic;

namespace AgGateway.ADAPT.ApplicationDataModel.Products
{
    [Obsolete("Use CropVarietyProduct from now on")]
    public class CropVariety : Product
    {
        public CropVariety()
        {
            TraitIds = new List<int>();
        }

        public int CropId { get; set; }

        public List<int> TraitIds { get; set; }

        public bool GeneticallyEnhanced { get; set; }
    }
}
