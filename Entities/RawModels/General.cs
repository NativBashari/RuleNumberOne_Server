using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.RawModels.FinancialData;

namespace Entities.RawModels
{

    public partial class General
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Exchange")]
        public string Exchange { get; set; }

        [JsonProperty("CurrencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("CurrencyName")]
        public string CurrencyName { get; set; }

        [JsonProperty("CurrencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("CountryName")]
        public string CountryName { get; set; }

        [JsonProperty("CountryISO")]
        public string CountryIso { get; set; }

        [JsonProperty("OpenFigi")]
        public string OpenFigi { get; set; }

        [JsonProperty("ISIN")]
        public string Isin { get; set; }

        [JsonProperty("LEI")]
        public string Lei { get; set; }

        [JsonProperty("PrimaryTicker")]
        public string PrimaryTicker { get; set; }

        [JsonProperty("CUSIP")]
        public string Cusip { get; set; }

        [JsonProperty("CIK")]
        public long Cik { get; set; }

        [JsonProperty("EmployerIdNumber")]
        public string EmployerIdNumber { get; set; }

        [JsonProperty("FiscalYearEnd")]
        public string FiscalYearEnd { get; set; }

        [JsonProperty("IPODate")]
        public DateTimeOffset IpoDate { get; set; }

        [JsonProperty("InternationalDomestic")]
        public string InternationalDomestic { get; set; }

        [JsonProperty("Sector")]
        public string Sector { get; set; }

        [JsonProperty("Industry")]
        public string Industry { get; set; }

        [JsonProperty("GicSector")]
        public string GicSector { get; set; }

        [JsonProperty("GicGroup")]
        public string GicGroup { get; set; }

        [JsonProperty("GicIndustry")]
        public string GicIndustry { get; set; }

        [JsonProperty("GicSubIndustry")]
        public string GicSubIndustry { get; set; }

        [JsonProperty("HomeCategory")]
        public string HomeCategory { get; set; }

        [JsonProperty("IsDelisted")]
        public bool IsDelisted { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("AddressData")]
        public AddressData AddressData { get; set; }

        [JsonProperty("Listings")]
        public Dictionary<string, Listing> Listings { get; set; }

        [JsonProperty("Officers")]
        public Dictionary<string, Officer> Officers { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("WebURL")]
        public Uri WebUrl { get; set; }

        [JsonProperty("LogoURL")]
        public string LogoUrl { get; set; }

        [JsonProperty("FullTimeEmployees")]
        public long FullTimeEmployees { get; set; }

        [JsonProperty("UpdatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class AddressData
    {
        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("ZIP")]
        public long Zip { get; set; }
    }

    public partial class Listing
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Exchange")]
        public string Exchange { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public partial class Officer
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("YearBorn")]
        public string YearBorn { get; set; }
    }
}
