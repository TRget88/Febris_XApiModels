// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Statement: IStatement
    {
        //################################################################
        //this needs to be uuid (or guid) can be set up automatically with postgres       
        //################################################################
        public long Id { get; set; }
        public Guid UUID { get; set; }

        //################################################################
        //if not provided needs to set by api
        //################################################################
        public DateTime Timestamp { get; set; }

        //################################################################
        //Set this inside Db for when the record is stored
        //################################################################
        public DateTime Stored { get; set; }

        //################################################################
        //xApi required fields
        //################################################################
        [Required]
        public Actor Actor { get; set; }
        [Required]
        public Verb Verb { get; set; }
        [Required]
        public Object Object { get; set; }

        //################################################################
        //Optional Fields
        //attachments needs to be an ordered array of objects
        //################################################################
        public Result Result { get; set; }
        public Context Context { get; set; }
        public Authority Authority { get; set; }
        public Version Version { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
