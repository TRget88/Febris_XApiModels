// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Authority: IAuthority
    {
        //1
        public long Id { get; set; }
        public Guid UUID { get; set; }
        //2        
        public Actor Actor { get; set; }
    }
}
