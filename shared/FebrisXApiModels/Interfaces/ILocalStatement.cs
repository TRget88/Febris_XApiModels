// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface ILocalStatement
    {        
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
        long VerbId { get; set; }
        Guid VerbUUID { get; set; }
        long ObjectId { get; set; }
        Guid ObjectUUID { get; set; }

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
