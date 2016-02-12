/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Tarak Reddy, Tim Shearouse - initial API and implementation
  *******************************************************************************/

using System;
using AgGateway.ADAPT.ApplicationDataModel.Shapes;

namespace AgGateway.ADAPT.ApplicationDataModel.ReferenceLayers
{
    public class ShapeLookup : MarshalByRefObject
    {
        public Shape Shape { get; set; }

        public SpatialAttribute SpatialAttribute { get; set; }
    }
}