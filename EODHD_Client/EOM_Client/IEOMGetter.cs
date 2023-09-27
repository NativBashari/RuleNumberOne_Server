using Entities.EOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODHD_Client.EOM_Client
{
    public interface IEOMGetter
    {
        public Task<List<EOM>> GetEOMAsync(string stockID);

    }
}
