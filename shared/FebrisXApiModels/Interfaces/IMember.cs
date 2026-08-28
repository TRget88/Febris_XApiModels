// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;
using System.Collections.Generic;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IMember
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        List<Actor> Actors { get; set; }
    }
}