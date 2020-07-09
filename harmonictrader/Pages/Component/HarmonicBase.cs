using harmonictrader.Services;
using harmonictrader.ViewModel;

using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace harmonictrader.Pages
{
    public class HarmonicBase : ComponentBase
    {
        public IEnumerable<Pattern> Patterns { get; set; }
        [Inject]
        IPatternService PatternService { get; set; }

        public double RetracementRatio { get; set; }
        protected override async Task OnInitializedAsync()
        {
            RetracementRatio = Double.NaN;
            Patterns = (await PatternService.GetAll()).ToList();
        }

        public void OnRatioChanged(ChangeEventArgs e)
        {
            RetracementRatio = Convert.ToDouble(e.Value);
            var computedRatios = new List<double>();
            Patterns.ToList().ForEach(p => p.XA.ToList().ForEach(x => computedRatios.Add(Math.Abs(RetracementRatio - x))));
            var lowest = computedRatios.Min();
            //Patterns.ToList().ForEach(p => p.XA.ToList().ForEach(
            //    x => p.IsClosestRatio = Math.Abs(RetracementRatio - x) == lowest
            //));
            foreach (var p in Patterns)
            {
                foreach (var x in p.XA)
                {
                    p.IsClosestRatio = Math.Abs(RetracementRatio - x) == lowest;
                    if (p.IsClosestRatio) break;
                }
            }

        }
    }
}
