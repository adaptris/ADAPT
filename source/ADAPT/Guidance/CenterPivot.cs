using AgGateway.ADAPT.ApplicationDataModel.Shapes;
using System;

namespace AgGateway.ADAPT.ApplicationDataModel.Guidance
{
    [Obsolete("Use PivotGuidancePattern from now on")]
    public class CenterPivot : GuidancePattern
    {
        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }

        public Point Center { get; set; }
    }
}
