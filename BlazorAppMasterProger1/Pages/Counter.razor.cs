using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BlazorAppMasterProger1.Model;

namespace BlazorAppMasterProger1.Pages
{
    public partial class Counter
    {
        [Inject] SingltonServices _singleton { get; set; }
        [Inject] TransientServices _transient { get; set; }

        [CascadingParameter] public AppStyle Styles { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            _singleton.Value = currentCount;
            _transient.Value = currentCount;
        }
    }
}
