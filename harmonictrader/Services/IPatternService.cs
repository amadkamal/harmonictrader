using harmonictrader.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harmonictrader.Services
{
    public interface IPatternService
    {
        Task<IEnumerable<Pattern>> GetAll();
    }
}
