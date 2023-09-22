using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;


namespace Entities.RawModels
{
    public partial class FinancialData
    {
        [JsonProperty("General")]
        public General General { get; set; }

        [JsonProperty("Highlights")]
        public Highlights Highlights { get; set; }

        [JsonProperty("Valuation")]
        public Valuation Valuation { get; set; }

        [JsonProperty("SharesStats")]
        public SharesStats SharesStats { get; set; }

        [JsonProperty("Technicals")]
        public Dictionary<string, double> Technicals { get; set; }

        [JsonProperty("SplitsDividends")]
        public SplitsDividends SplitsDividends { get; set; }

        [JsonProperty("AnalystRatings")]
        public AnalystRatings AnalystRatings { get; set; }

        [JsonProperty("Holders")]
        public Holders Holders { get; set; }

        [JsonProperty("InsiderTransactions")]
        public Dictionary<string, InsiderTransaction> InsiderTransactions { get; set; }

        [JsonProperty("ESGScores")]
        public EsgScores EsgScores { get; set; }

        [JsonProperty("outstandingShares")]
        public OutstandingShares OutstandingShares { get; set; }

        [JsonProperty("Earnings")]
        public Earnings Earnings { get; set; }

        [JsonProperty("Financials")]
        public Financials Financials { get; set; }
    }

    public partial class AnalystRatings
    {
        [JsonProperty("Rating")]
        public double Rating { get; set; }

        [JsonProperty("TargetPrice")]
        public double TargetPrice { get; set; }

        [JsonProperty("StrongBuy")]
        public long StrongBuy { get; set; }

        [JsonProperty("Buy")]
        public long Buy { get; set; }

        [JsonProperty("Hold")]
        public long Hold { get; set; }

        [JsonProperty("Sell")]
        public long Sell { get; set; }

        [JsonProperty("StrongSell")]
        public long StrongSell { get; set; }
    }

    public partial class Earnings
    {
        [JsonProperty("History")]
        public Dictionary<string, History> History { get; set; }

        [JsonProperty("Trend")]
        public Dictionary<string, Dictionary<string, string>> Trend { get; set; }

        [JsonProperty("Annual")]
        public Dictionary<string, Annual> Annual { get; set; }
    }

    public partial class Annual
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("epsActual")]
        public double EpsActual { get; set; }
    }

    public partial class History
    {
        [JsonProperty("reportDate")]
        public DateTimeOffset ReportDate { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("beforeAfterMarket")]
        public BeforeAfterMarket? BeforeAfterMarket { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("epsActual")]
        public double? EpsActual { get; set; }

        [JsonProperty("epsEstimate")]
        public double? EpsEstimate { get; set; }

        [JsonProperty("epsDifference")]
        public double? EpsDifference { get; set; }

        [JsonProperty("surprisePercent")]
        public double? SurprisePercent { get; set; }
    }

    public partial class EsgScores
    {
        [JsonProperty("Disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("RatingDate")]
        public DateTimeOffset RatingDate { get; set; }

        [JsonProperty("TotalEsg")]
        public double TotalEsg { get; set; }

        [JsonProperty("TotalEsgPercentile")]
        public double TotalEsgPercentile { get; set; }

        [JsonProperty("EnvironmentScore")]
        public double EnvironmentScore { get; set; }

        [JsonProperty("EnvironmentScorePercentile")]
        public long EnvironmentScorePercentile { get; set; }

        [JsonProperty("SocialScore")]
        public double SocialScore { get; set; }

        [JsonProperty("SocialScorePercentile")]
        public long SocialScorePercentile { get; set; }

        [JsonProperty("GovernanceScore")]
        public double GovernanceScore { get; set; }

        [JsonProperty("GovernanceScorePercentile")]
        public long GovernanceScorePercentile { get; set; }

        [JsonProperty("ControversyLevel")]
        public long ControversyLevel { get; set; }

        [JsonProperty("ActivitiesInvolvement")]
        public Dictionary<string, ActivitiesInvolvement> ActivitiesInvolvement { get; set; }
    }

    public partial class ActivitiesInvolvement
    {
        [JsonProperty("Activity")]
        public string Activity { get; set; }

        [JsonProperty("Involvement")]
        public Involvement Involvement { get; set; }
    }

    public partial class Financials
    {
        [JsonProperty("Balance_Sheet")]
        public BalanceSheet BalanceSheet { get; set; }

        [JsonProperty("Cash_Flow")]
        public CashFlow CashFlow { get; set; }

        [JsonProperty("Income_Statement")]
        public IncomeStatement IncomeStatement { get; set; }
    }

    public partial class BalanceSheet
    {
        [JsonProperty("currency_symbol")]
        public Currency CurrencySymbol { get; set; }

        [JsonProperty("quarterly")]
        public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

        [JsonProperty("yearly")]
        public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
    }

    public partial class CashFlow
    {
        [JsonProperty("currency_symbol")]
        public Currency CurrencySymbol { get; set; }

        [JsonProperty("quarterly")]
        public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

        [JsonProperty("yearly")]
        public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
    }

    public partial class IncomeStatement
    {
        [JsonProperty("currency_symbol")]
        public Currency CurrencySymbol { get; set; }

        [JsonProperty("quarterly")]
        public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

        [JsonProperty("yearly")]
        public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
    }

    public partial class General
    {
        [JsonProperty("Code")]
        public Code Code { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Name")]
        public Name Name { get; set; }

        [JsonProperty("Exchange")]
        public string Exchange { get; set; }

        [JsonProperty("CurrencyCode")]
        public Currency CurrencyCode { get; set; }

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
        [JsonConverter(typeof(ParseStringConverter))]
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
        [JsonConverter(typeof(ParseStringConverter))]
        public long Zip { get; set; }
    }

    public partial class Listing
    {
        [JsonProperty("Code")]
        public Code Code { get; set; }

        [JsonProperty("Exchange")]
        public string Exchange { get; set; }

        [JsonProperty("Name")]
        public Name Name { get; set; }
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

    public partial class Highlights
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

    public partial class Holders
    {
        [JsonProperty("Institutions")]
        public Dictionary<string, Fund> Institutions { get; set; }

        [JsonProperty("Funds")]
        public Dictionary<string, Fund> Funds { get; set; }
    }

    public partial class Fund
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("totalShares")]
        public double TotalShares { get; set; }

        [JsonProperty("totalAssets")]
        public double TotalAssets { get; set; }

        [JsonProperty("currentShares")]
        public long CurrentShares { get; set; }

        [JsonProperty("change")]
        public long Change { get; set; }

        [JsonProperty("change_p")]
        public double ChangeP { get; set; }
    }

    public partial class InsiderTransaction
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("ownerCik")]
        public object OwnerCik { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("transactionDate")]
        public DateTimeOffset TransactionDate { get; set; }

        [JsonProperty("transactionCode")]
        public TransactionCode TransactionCode { get; set; }

        [JsonProperty("transactionAmount")]
        public long TransactionAmount { get; set; }

        [JsonProperty("transactionPrice")]
        public double TransactionPrice { get; set; }

        [JsonProperty("transactionAcquiredDisposed")]
        public TransactionAcquiredDisposed TransactionAcquiredDisposed { get; set; }

        [JsonProperty("postTransactionAmount")]
        public long PostTransactionAmount { get; set; }

        [JsonProperty("secLink")]
        public Uri SecLink { get; set; }
    }

    public partial class OutstandingShares
    {
        [JsonProperty("annual")]
        public Dictionary<string, AnnualValue> Annual { get; set; }

        [JsonProperty("quarterly")]
        public Dictionary<string, AnnualValue> Quarterly { get; set; }
    }

    public partial class AnnualValue
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateFormatted")]
        public DateTimeOffset DateFormatted { get; set; }

        [JsonProperty("sharesMln")]
        public string SharesMln { get; set; }

        [JsonProperty("shares")]
        public double Shares { get; set; }
    }

    public partial class SharesStats
    {
        [JsonProperty("SharesOutstanding")]
        public long SharesOutstanding { get; set; }

        [JsonProperty("SharesFloat")]
        public long SharesFloat { get; set; }

        [JsonProperty("PercentInsiders")]
        public double PercentInsiders { get; set; }

        [JsonProperty("PercentInstitutions")]
        public double PercentInstitutions { get; set; }

        [JsonProperty("SharesShort")]
        public object SharesShort { get; set; }

        [JsonProperty("SharesShortPriorMonth")]
        public object SharesShortPriorMonth { get; set; }

        [JsonProperty("ShortRatio")]
        public object ShortRatio { get; set; }

        [JsonProperty("ShortPercentOutstanding")]
        public object ShortPercentOutstanding { get; set; }

        [JsonProperty("ShortPercentFloat")]
        public object ShortPercentFloat { get; set; }
    }

    public partial class SplitsDividends
    {
        [JsonProperty("ForwardAnnualDividendRate")]
        public double ForwardAnnualDividendRate { get; set; }

        [JsonProperty("ForwardAnnualDividendYield")]
        public double ForwardAnnualDividendYield { get; set; }

        [JsonProperty("PayoutRatio")]
        public double PayoutRatio { get; set; }

        [JsonProperty("DividendDate")]
        public DateTimeOffset DividendDate { get; set; }

        [JsonProperty("ExDividendDate")]
        public DateTimeOffset ExDividendDate { get; set; }

        [JsonProperty("LastSplitFactor")]
        public string LastSplitFactor { get; set; }

        [JsonProperty("LastSplitDate")]
        public DateTimeOffset LastSplitDate { get; set; }

        [JsonProperty("NumberDividendsByYear")]
        public Dictionary<string, NumberDividendsByYear> NumberDividendsByYear { get; set; }
    }

    public partial class NumberDividendsByYear
    {
        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }
    }

    public partial class Valuation
    {
        [JsonProperty("TrailingPE")]
        public double TrailingPe { get; set; }

        [JsonProperty("ForwardPE")]
        public double ForwardPe { get; set; }

        [JsonProperty("PriceSalesTTM")]
        public double PriceSalesTtm { get; set; }

        [JsonProperty("PriceBookMRQ")]
        public double PriceBookMrq { get; set; }

        [JsonProperty("EnterpriseValue")]
        public long EnterpriseValue { get; set; }

        [JsonProperty("EnterpriseValueRevenue")]
        public double EnterpriseValueRevenue { get; set; }

        [JsonProperty("EnterpriseValueEbitda")]
        public double EnterpriseValueEbitda { get; set; }
    }

    public enum BeforeAfterMarket { AfterMarket, BeforeMarket };

    public enum Currency { Usd };

    public enum Involvement { No };

    public enum Code { Aapl, Aapl34, Apc, The0R2V };

    public enum Name { AppleInc, AppleIncCdr, AppleIncDrc, NameAppleInc };

    public enum TransactionAcquiredDisposed { D };

    public enum TransactionCode { S };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                InvolvementConverter.Singleton,
                BeforeAfterMarketConverter.Singleton,
                CurrencyConverter.Singleton,
                CodeConverter.Singleton,
                NameConverter.Singleton,
                TransactionAcquiredDisposedConverter.Singleton,
                TransactionCodeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class InvolvementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Involvement) || t == typeof(Involvement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "No")
            {
                return Involvement.No;
            }
            throw new Exception("Cannot unmarshal type Involvement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Involvement)untypedValue;
            if (value == Involvement.No)
            {
                serializer.Serialize(writer, "No");
                return;
            }
            throw new Exception("Cannot marshal type Involvement");
        }

        public static readonly InvolvementConverter Singleton = new InvolvementConverter();
    }

    internal class BeforeAfterMarketConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BeforeAfterMarket) || t == typeof(BeforeAfterMarket?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AfterMarket":
                    return BeforeAfterMarket.AfterMarket;
                case "BeforeMarket":
                    return BeforeAfterMarket.BeforeMarket;
            }
            throw new Exception("Cannot unmarshal type BeforeAfterMarket");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BeforeAfterMarket)untypedValue;
            switch (value)
            {
                case BeforeAfterMarket.AfterMarket:
                    serializer.Serialize(writer, "AfterMarket");
                    return;
                case BeforeAfterMarket.BeforeMarket:
                    serializer.Serialize(writer, "BeforeMarket");
                    return;
            }
            throw new Exception("Cannot marshal type BeforeAfterMarket");
        }

        public static readonly BeforeAfterMarketConverter Singleton = new BeforeAfterMarketConverter();
    }

    internal class CurrencyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Currency) || t == typeof(Currency?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "USD")
            {
                return Currency.Usd;
            }
            throw new Exception("Cannot unmarshal type Currency");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Currency)untypedValue;
            if (value == Currency.Usd)
            {
                serializer.Serialize(writer, "USD");
                return;
            }
            throw new Exception("Cannot marshal type Currency");
        }

        public static readonly CurrencyConverter Singleton = new CurrencyConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class CodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Code) || t == typeof(Code?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0R2V":
                    return Code.The0R2V;
                case "AAPL":
                    return Code.Aapl;
                case "AAPL34":
                    return Code.Aapl34;
                case "APC":
                    return Code.Apc;
            }
            throw new Exception("Cannot unmarshal type Code");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Code)untypedValue;
            switch (value)
            {
                case Code.The0R2V:
                    serializer.Serialize(writer, "0R2V");
                    return;
                case Code.Aapl:
                    serializer.Serialize(writer, "AAPL");
                    return;
                case Code.Aapl34:
                    serializer.Serialize(writer, "AAPL34");
                    return;
                case Code.Apc:
                    serializer.Serialize(writer, "APC");
                    return;
            }
            throw new Exception("Cannot marshal type Code");
        }

        public static readonly CodeConverter Singleton = new CodeConverter();
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Apple Inc":
                    return Name.NameAppleInc;
                case "Apple Inc CDR":
                    return Name.AppleIncCdr;
                case "Apple Inc DRC":
                    return Name.AppleIncDrc;
                case "Apple Inc.":
                    return Name.AppleInc;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.NameAppleInc:
                    serializer.Serialize(writer, "Apple Inc");
                    return;
                case Name.AppleIncCdr:
                    serializer.Serialize(writer, "Apple Inc CDR");
                    return;
                case Name.AppleIncDrc:
                    serializer.Serialize(writer, "Apple Inc DRC");
                    return;
                case Name.AppleInc:
                    serializer.Serialize(writer, "Apple Inc.");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class TransactionAcquiredDisposedConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransactionAcquiredDisposed) || t == typeof(TransactionAcquiredDisposed?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "D")
            {
                return TransactionAcquiredDisposed.D;
            }
            throw new Exception("Cannot unmarshal type TransactionAcquiredDisposed");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TransactionAcquiredDisposed)untypedValue;
            if (value == TransactionAcquiredDisposed.D)
            {
                serializer.Serialize(writer, "D");
                return;
            }
            throw new Exception("Cannot marshal type TransactionAcquiredDisposed");
        }

        public static readonly TransactionAcquiredDisposedConverter Singleton = new TransactionAcquiredDisposedConverter();
    }

    internal class TransactionCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransactionCode) || t == typeof(TransactionCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "S")
            {
                return TransactionCode.S;
            }
            throw new Exception("Cannot unmarshal type TransactionCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TransactionCode)untypedValue;
            if (value == TransactionCode.S)
            {
                serializer.Serialize(writer, "S");
                return;
            }
            throw new Exception("Cannot marshal type TransactionCode");
        }

        public static readonly TransactionCodeConverter Singleton = new TransactionCodeConverter();
    }
}
