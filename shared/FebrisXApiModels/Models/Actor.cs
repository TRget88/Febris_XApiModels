// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Actor : IActor
    {
        //1
        public long Id { get; set; }
        public Guid UUID { get; set; }
        //2
        public string ObjectType { get; set; }
        public string Name { get; set; }
        //3 
        public Uri Mbox { get; set; }
        public string Mbox_sha1sum { get; set; }
        public Uri OpenId { get; set; }
        public Account Account { get; set; }
        //4        
        public Member Member { get; set; }
    }
}
