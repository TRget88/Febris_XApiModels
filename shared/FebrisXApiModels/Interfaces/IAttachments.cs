// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using System;
using System.Collections.Generic;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IAttachments
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        //2
        Uri UsageType { get; set; }

        //3
        Dictionary<string, string> Display { get; set; }
        Dictionary<string, string> Description { get; set; }

        //4        
        string ContentType { get; set; } //ie "application/octet-stream"
        //5         
        int Length { get; set; }
        //6        
        string Sha2 { get; set; }
        //7
        Uri FileURL { get; set; }//user UUID to name video file
    }
}