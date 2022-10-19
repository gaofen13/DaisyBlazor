﻿using DaisyBlazor.Utilities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisyBlazor
{
    public partial class DaisyCollapse
    {
        private string Classname =>
            new ClassBuilder("collapse collapse-arrow")
            .AddClass("collapse-open", !Collapsed)
            .Build();

        [Parameter]
        public bool Collapsed { get; set; } = true;

        [Parameter]
        public EventCallback<bool> CollapsedChanged { get; set; }

        [Parameter]
        public string? Title { get; set; }

        [Parameter]
        public RenderFragment? TitleContent { get; set; }

        [Parameter]
        public string? Message { get; set; }

        [Parameter]
        public RenderFragment? MessageContent { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnTitleClicked { get; set; }

        private async Task OnClickTitleAsync(MouseEventArgs args)
        {
            if (OnTitleClicked.HasDelegate)
            {
                await OnTitleClicked.InvokeAsync(args);
            }
            else
            {
                Collapsed = !Collapsed;
                await CollapsedChanged.InvokeAsync(Collapsed);
            }
        }
    }
}
