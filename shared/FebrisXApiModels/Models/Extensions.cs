// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Extensions: IExtensions
    {
        public long Id { get; set; }
        //check page 50
        public Guid UUID { get; set; } // lets use this to link? otherwise it is not stated as needed

        public string ExtensionMap { get; set; }
    }
}
