// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;
using System.Collections.Generic;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IVerb
    {
        long Key { get; set; }
        Guid UUID { get; set; }

        Uri Id { get; set; }//must be an IRI, e.g. https://example.org/xapi/verbs/attempted

        Dictionary<string, string> Display { get; set; }
    }
}