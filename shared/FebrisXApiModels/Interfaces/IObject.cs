// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IObject
    {
        long Key { get; set; }
        Guid UUID { get; set; }
        Uri Id { get; set; }
        string ObjectType { get; set; }
        Definition Definition { get; set; }
    }
}