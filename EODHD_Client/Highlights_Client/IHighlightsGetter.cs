using Entities.RawModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODHD_Client.Highlights_Client
{
    public interface IHighlightsGetter
    {
        Task<Highlights> GetHighlightsAsync(string stockId);
    }
}
