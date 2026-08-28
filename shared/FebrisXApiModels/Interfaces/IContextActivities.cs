// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IContextActivities
    {
        long Id { get; set; }
        Guid UUID { get; set; }

        string Parent { get; set; }
        string Grouping { get; set; }
        string Category { get; set; }
        string Other { get; set; }
    }
}