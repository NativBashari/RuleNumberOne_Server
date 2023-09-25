using Entities.RawModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODHD_Client.Fundamentals_Client
{
    public interface IFinanceGetter
    {
        Task<FinancialData> GetFinancialDataAsync(string stockID);
    }
}
