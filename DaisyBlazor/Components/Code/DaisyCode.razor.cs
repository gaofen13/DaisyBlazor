﻿using DaisyBlazor.Utilities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisyBlazor
{
    public partial class DaisyCode
    {
        private string Classname =>
            new ClassBuilder("mockup-code")
            .AddClass(Class)
            .Build();

        [Parameter]
        public RenderFragment? PreList { get; set; }
    }
}
