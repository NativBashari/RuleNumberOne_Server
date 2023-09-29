using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RawModels
{
    public class Highlights
    {
        [JsonProperty("MarketCapitalization")]
        public long MarketCapitalization { get; set; }

        [JsonProperty("MarketCapitalizationMln")]
        public double MarketCapitalizationMln { get; set; }

        [JsonProperty("EBITDA")]
        public long Ebitda { get; set; }

        [JsonProperty("PERatio")]
        public double PeRatio { get; set; }

        [JsonProperty("PEGRatio")]
        public double PegRatio { get; set; }

        [JsonProperty("WallStreetTargetPrice")]
        public double WallStreetTargetPrice { get; set; }

        [JsonProperty("BookValue")]
        public double BookValue { get; set; }

        [JsonProperty("DividendShare")]
        public double DividendShare { get; set; }

        [JsonProperty("DividendYield")]
        public double DividendYield { get; set; }

        [JsonProperty("EarningsShare")]
        public double EarningsShare { get; set; }

        [JsonProperty("EPSEstimateCurrentYear")]
        public double EpsEstimateCurrentYear { get; set; }

        [JsonProperty("EPSEstimateNextYear")]
        public double EpsEstimateNextYear { get; set; }

        [JsonProperty("EPSEstimateNextQuarter")]
        public double EpsEstimateNextQuarter { get; set; }

        [JsonProperty("EPSEstimateCurrentQuarter")]
        public double EpsEstimateCurrentQuarter { get; set; }

        [JsonProperty("MostRecentQuarter")]
        public DateTimeOffset MostRecentQuarter { get; set; }

        [JsonProperty("ProfitMargin")]
        public double ProfitMargin { get; set; }

        [JsonProperty("OperatingMarginTTM")]
        public double OperatingMarginTtm { get; set; }

        [JsonProperty("ReturnOnAssetsTTM")]
        public double ReturnOnAssetsTtm { get; set; }

        [JsonProperty("ReturnOnEquityTTM")]
        public double ReturnOnEquityTtm { get; set; }

        [JsonProperty("RevenueTTM")]
        public long RevenueTtm { get; set; }

        [JsonProperty("RevenuePerShareTTM")]
        public double RevenuePerShareTtm { get; set; }

        [JsonProperty("QuarterlyRevenueGrowthYOY")]
        public double QuarterlyRevenueGrowthYoy { get; set; }

        [JsonProperty("GrossProfitTTM")]
        public long GrossProfitTtm { get; set; }

        [JsonProperty("DilutedEpsTTM")]
        public double DilutedEpsTtm { get; set; }

        [JsonProperty("QuarterlyEarningsGrowthYOY")]
        public double QuarterlyEarningsGrowthYoy { get; set; }
    }
}
