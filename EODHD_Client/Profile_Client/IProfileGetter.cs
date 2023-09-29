using Entities.RawModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODHD_Client.Profile_Client
{
    public interface IProfileGetter
    {
         public Task<General> GetProfileDataAsync(string stockID);

    }
}
