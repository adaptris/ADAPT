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
  *    Kathleen Oneal - make slope nullable
  *    Justin Sliekers - removing M and Slope, making Z nullable
  *******************************************************************************/  

namespace AgGateway.ADAPT.ApplicationDataModel.Shapes
{
    public class Point : Shape
    {
        public Point()
        {
            Type = ShapeTypeEnum.Point;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }
    }
}