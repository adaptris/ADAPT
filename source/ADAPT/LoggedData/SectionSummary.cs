﻿/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Tarak Reddy, Tim Shearouse - initial API and implementation
  *    Joseph Ross Making Properties
  *******************************************************************************/

using System;
using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ApplicationDataModel.Representations;

namespace AgGateway.ADAPT.ApplicationDataModel.LoggedData
{
    public class SectionSummary : MarshalByRefObject
    {
        public SectionSummary()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
        }

        public CompoundIdentifier Id { get; private set; }

        public int SectionId { get; set; }

        public NumericRepresentation TotalDistanceTravelled { get; set; }

        public NumericRepresentation TotalElapsedTime { get; set; }
    }
}
