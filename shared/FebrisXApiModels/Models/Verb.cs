// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Verb: IVerb
    {
        [Key]
        public long Key { get; set; }
        public Guid UUID { get; set; }
        [Display(Name = "IRI used to reference this Verb (leave blank if new)")]
        public Uri Id { get; set; }//must be an IRI, e.g. https://example.org/xapi/verbs/attempted        

        // xAPI 1.0.3 Language Map: locale -> text (e.g. {"en-US":"completed"}). Persisted as jsonb.
        public Dictionary<string, string> Display { get; set; }
    }
}
