using Entities.EOM;
using Entities.FinalModels.Fundamentals;
using Entities.FinalModels.Profile;

namespace Logic.Contracts
{
    public interface IUnitOfWork
    {
        public Task<FinancialData_Final> GetFinancialSummury(string stockMarkup);
        public Task<Profile_Final> GetProfileData(string id);

        public Task<List<EOM>> GetEOM(string id); 
    }
}
