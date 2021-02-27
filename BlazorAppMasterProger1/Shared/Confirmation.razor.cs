using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppMasterProger1.Shared
{
    public partial class Confirmation
    {
        [Parameter] public string Title { get; set; } = "Confrim";

        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter] public EventCallback onConfrim { get; set; }

        [Parameter] public EventCallback onCancel { get; set; }

        bool _displayConfirmation = false;

        public void Show()
        {
            _displayConfirmation = true;
        }

        public void Hide()
        {
            _displayConfirmation = false;
        }
    }
}
