// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;
using System.Collections.Generic;
using Febris.ModelLibrary.Models.XApiModels;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IDefinition
    {
        long Id { get; set; }
        Guid UUID { get; set; } // lets use this to link? otherwise it is not stated as needed

        //2
        Dictionary<string, string> Name { get; set; }
        Dictionary<string, string> Description { get; set; }

        //3
        Uri Type { get; set; }
        Uri MoreInfo { get; set; }

        //4
        Extensions Extensions { get; set; }

        //5
        string InteractionType { get; set; }
        List<string> CorrectResponsesPattern { get; set; }

        //6
        string InteractionComponents { get; set; }
    }
}