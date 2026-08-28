// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IScore
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        float Scaled { get; set; }
        float Raw { get; set; }
        float Min { get; set; }
        float Max { get; set; }
    }
}