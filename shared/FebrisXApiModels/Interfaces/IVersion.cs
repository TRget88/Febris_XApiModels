// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IVersion
    {
        long Id { get; set; }
        Guid UUID { get; set; } 
        string VersionNumber { get; set; }
    }
}