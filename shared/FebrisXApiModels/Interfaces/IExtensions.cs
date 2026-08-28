// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IExtensions
    {
        long Id { get; set; }
        //check page 50
        Guid UUID { get; set; } // lets use this to link? otherwise it is not stated as needed

        string ExtensionMap { get; set; }
    }
}