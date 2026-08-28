// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class StatementReference: IStatementReference
    {
        [Key]
        public long Key { get; set; }
        public Guid UUID { get; set; }
        public Guid Id { get; set; }
        public string ObjectType { get; set; }
    }
}
