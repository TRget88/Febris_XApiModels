// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Score: IScore
    {
        public long Id { get; set; }
        public Guid UUID { get; set; }
        // NOTE (LMS-B4): Score fields (Scaled, Raw, Min, Max) are non-nullable float, so absent xAPI fields default to 0.0 and lose the distinction between no-score-reported and scored-zero. Proper fix needs nullable float (or decimal) plus an EF Core migration on XApiDB and TestUserXApiDB. Deferred per do-not-change-functionality.
        public float Scaled { get; set; }
        public float Raw { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }
    }
}
