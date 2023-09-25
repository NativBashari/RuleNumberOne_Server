using Entities.FinalModels.Profile;
using Entities.RawModels;
using Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class ProfileLogic : IProfileLogic
    {
        public async Task<Profile_Final> GetFinalProfile(General rawGeneralInformation)
        {
            Profile_Final profileFinal = new Profile_Final()
            {
                Address = rawGeneralInformation.Address,
                Code = rawGeneralInformation.Code,
                CountryName = rawGeneralInformation.CountryName,
                Description = rawGeneralInformation.Description,
                Employees = rawGeneralInformation.FullTimeEmployees.ToString(),
                Exchange = rawGeneralInformation.Exchange,
                Industry = rawGeneralInformation.Industry,
                LogoUrl = rawGeneralInformation.LogoUrl,
                Name = rawGeneralInformation.Name,
                Sector = rawGeneralInformation.Sector,
                Type = rawGeneralInformation.Type,
                WebSiteUrl = rawGeneralInformation.WebUrl.AbsoluteUri
            };
            foreach(var entry in rawGeneralInformation.Officers)
            {
                profileFinal.Officer_Finals.Add(new Officer_Final() { Name = entry.Value.Name, Title = entry.Value.Title, YearBorn = entry.Value.YearBorn });
            }
            return profileFinal;


        }
    }
}
