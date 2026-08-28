// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IAuthority
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        //2        
        Actor Actor { get; set; }
    }
}