// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IActor
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        //2
        string ObjectType { get; set; }
        string Name { get; set; }
        //3 
        Uri Mbox { get; set; }
        string Mbox_sha1sum { get; set; }
        Uri OpenId { get; set; }
        Account Account { get; set; }
        //4        
        Member Member { get; set; }
    }
}