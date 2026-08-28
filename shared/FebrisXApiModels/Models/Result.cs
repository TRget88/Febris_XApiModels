// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Result: IResult
    {
        public long Id { get; set; }
        public Guid UUID { get; set; }
        public Score Score { get; set; }
        public bool? Success { get; set; }
        public bool? Completion { get; set; }
        public string Response { get; set; }
        public TimeSpan Duration { get; set; }
        public Extensions Extensions { get; set; }
    }
}
