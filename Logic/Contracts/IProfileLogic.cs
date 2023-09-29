using Entities.FinalModels.Profile;
using Entities.RawModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface IProfileLogic
    {
        public Task<Profile_Final> GetFinalProfile(General rawGeneralInformation);
    }
}
