// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Definition: IDefinition
    {
        //1
        public long Id { get; set; }
        public Guid UUID { get; set; } // lets use this to link? otherwise it is not stated as needed

        //2  xAPI 1.0.3 Language Maps (locale -> text). Persisted as jsonb.
        public Dictionary<string, string> Name { get; set; }
        public Dictionary<string, string> Description { get; set; }

        //3
        public Uri Type { get; set; }
        public Uri MoreInfo { get; set; }

        //4
        public Extensions Extensions { get; set; }

        //5
        public string InteractionType { get; set; }
        // xAPI 1.0.3 interaction: an array of the correct-response pattern strings. Persisted as text[].
        public List<string> CorrectResponsesPattern { get; set; }

        //6
        public string InteractionComponents { get; set; }
    }
}
