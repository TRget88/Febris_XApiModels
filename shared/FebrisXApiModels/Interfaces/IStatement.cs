// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;
using System.Collections.Generic;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IStatement
    {
        //################################################################
        //this needs to be uuid (or guid) can be set up automatically with postgres       
        //################################################################
        long Id { get; set; }
        Guid UUID { get; set; }

        //################################################################
        //if not provided needs to set by api
        //################################################################
        DateTime Timestamp { get; set; }

        //################################################################
        //Set this inside Db for when the record is stored
        //################################################################
        DateTime Stored { get; set; }

        //################################################################
        //xApi required fields
        //################################################################
        Actor Actor { get; set; }
        
        Verb Verb { get; set; }

        Models.XApiModels.Object Object { get; set; }

        //################################################################
        //Optional Fields
        //attachments needs to be an ordered array of objects
        //################################################################
        Result Result { get; set; }
        Context Context { get; set; }
        Authority Authority { get; set; }
        Models.XApiModels.Version Version { get; set; }
        List<Attachment> Attachments { get; set; }
    }
}
