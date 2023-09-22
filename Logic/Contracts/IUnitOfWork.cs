using Entities.FinalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface IUnitOfWork
    {
        public Task<FinancialData_Final> GetFinancialSummury();
    }
}
