// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IAccount
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        Uri HomePage { get; set; }
        string Name { get; set; }
    }
}
