// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class ContextActivities: IContextActivities
    {
        public long Id { get; set; }
        public Guid UUID { get; set; }

        public string Parent { get; set; }
        public string Grouping { get; set; }
        public string Category { get; set; }
        public string Other { get; set; }

    }
}
