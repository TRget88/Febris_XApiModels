// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IStatementReference
    {
        long Key { get; set; }
        Guid UUID { get; set; }
        Guid Id { get; set; }
        string ObjectType { get; set; }
    }
}