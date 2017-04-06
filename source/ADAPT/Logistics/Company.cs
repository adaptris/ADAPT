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
 *    Kathleen Oneal - removed GLN, renamed ContactId to ContactInfoId
  *******************************************************************************/

using System.Collections.Generic;
using AgGateway.ADAPT.ApplicationDataModel.Common;

namespace AgGateway.ADAPT.ApplicationDataModel.Logistics
{
    public class Company
    {
        public Company()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
            ContextItems = new List<ContextItem>();
        }

        public CompoundIdentifier Id { get; private set; }

        public string Name { get; set; }

        public int ContactInfoId { get; set; }

        public List<ContextItem> ContextItems { get; set; } 
    }
}
