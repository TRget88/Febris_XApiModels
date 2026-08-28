// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;
using System.Collections.Generic;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IXApiResultExtras
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        Result Result { get; set; }
        Guid ResultUUID { get; set; }
        int RestartCount { get; set; }
        List<string> NotesList { get; set; }
    }
}