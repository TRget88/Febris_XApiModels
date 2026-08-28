// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Models.XApiModels;
using System;

namespace Febris.ModelLibrary.Interfaces.XApiModelInterfaces
{
    public interface IResult
    {
        long Id { get; set; }
        Guid UUID { get; set; }
        Score Score { get; set; }
        bool? Success { get; set; }
        bool? Completion { get; set; }
        string Response { get; set; }
        TimeSpan Duration { get; set; }
        Extensions Extensions { get; set; }
    }
}