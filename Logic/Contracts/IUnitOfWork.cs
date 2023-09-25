using Entities.FinalModels.Fundamentals;

namespace Logic.Contracts
{
    public interface IUnitOfWork
    {
        public Task<FinancialData_Final> GetFinancialSummury(string stockMarkup);
        

    }
}
