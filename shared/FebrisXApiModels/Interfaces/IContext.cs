// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;
using System.Collections.Generic;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IContext
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        //2
        Guid Registration { get; set; }
        //3
        Actor Instructor { get; set; }
        //4
        List<Actor> Group { get; set; }
        //5
        ContextActivities ContextActivities { get; set; }
        //6
        string Revision { get; set; }
        //7
        string Platform { get; set; }
        //8 
        string Language { get; set; }
        //9
        StatementReference StatementReference { get; set; }
        //10
        Extensions Extensions { get; set; }
    }
}