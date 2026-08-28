// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Attachment: IAttachments
    {
        //1
        public long Id { get; set; }
        public Guid UUID { get; set; }
        //2        
        public Uri UsageType { get; set; }

        //3  xAPI 1.0.3 Language Maps (locale -> text). Persisted as jsonb.
        public Dictionary<string, string> Display { get; set; }
        public Dictionary<string, string> Description { get; set; }

        //4        
        public string ContentType { get; set; } //ie "application/octet-stream"
        //5         
        public int Length { get; set; }
        //6        
        public string Sha2 { get; set; }
        //7
        public Uri FileURL { get; set; }//user UUID to name video file
    }
}
