using harmonictrader.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace harmonictrader.Services
{
    public class PatternService : IPatternService
    {
        private readonly HttpClient _httpClient;

        public PatternService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Pattern>> GetAll()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Pattern>>
                (await _httpClient.GetStreamAsync($"sample-data/harmonic.json"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
