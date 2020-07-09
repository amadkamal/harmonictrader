using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harmonictrader.Pages
{
    public class CounterBase : ComponentBase
    {
        public int currentCount = 0;

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
