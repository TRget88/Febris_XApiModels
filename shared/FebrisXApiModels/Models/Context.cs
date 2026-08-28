// SPDX-FileCopyrightText: 2026 Febris
// SPDX-License-Identifier: Apache-2.0
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Febris.ModelLibrary.Models.XApiModels
{
    public class Context: IContext
    {
        //1
        public long Id { get; set; }
        public Guid UUID { get; set; }
        //2
        public Guid Registration { get; set; }
        //3
        public Actor Instructor { get; set; }
        //4
        public List<Actor> Group { get; set; }
        //5
        public ContextActivities ContextActivities { get; set; }
        //6
        public string Revision { get; set; }
        //7
        public string Platform { get; set; }
        //8 
        public string Language { get; set; }
        //9
        public StatementReference StatementReference { get; set; }
        //10
        public Extensions Extensions { get; set; }
    }
}
