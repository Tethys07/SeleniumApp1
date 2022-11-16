using System.Collections.ObjectModel;

namespace SeleniumApp1.API.Models;
public class AppleStock
{
    public Quotesummary quoteSummary { get; set; }
}

public class Quotesummary
{
    public Result[] result { get; set; }
    public object error { get; set; }
}

public class Result
{
    public Assetprofile assetProfile { get; set; }
    public Recommendationtrend recommendationTrend { get; set; }
    public Cashflowstatementhistory cashflowStatementHistory { get; set; }
    public Indextrend indexTrend { get; set; }
    public Defaultkeystatistics defaultKeyStatistics { get; set; }
    public Industrytrend industryTrend { get; set; }
    public Incomestatementhistory incomeStatementHistory { get; set; }
    public Fundownership fundOwnership { get; set; }
    public Summarydetail summaryDetail { get; set; }
    public Insiderholders insiderHolders { get; set; }
    public Calendarevents calendarEvents { get; set; }
    public Upgradedowngradehistory upgradeDowngradeHistory { get; set; }
    public Price price { get; set; }
    public Balancesheethistory balanceSheetHistory { get; set; }
    public Earningstrend earningsTrend { get; set; }
    public Secfilings secFilings { get; set; }
    public Institutionownership institutionOwnership { get; set; }
    public Majorholdersbreakdown majorHoldersBreakdown { get; set; }
    public Balancesheethistoryquarterly balanceSheetHistoryQuarterly { get; set; }
    public Earningshistory earningsHistory { get; set; }
    public Majordirectholders majorDirectHolders { get; set; }
    public Esgscores esgScores { get; set; }
    public Summaryprofile summaryProfile { get; set; }
    public Netsharepurchaseactivity netSharePurchaseActivity { get; set; }
    public Insidertransactions insiderTransactions { get; set; }
    public Sectortrend sectorTrend { get; set; }
    public Incomestatementhistoryquarterly incomeStatementHistoryQuarterly { get; set; }
    public Cashflowstatementhistoryquarterly cashflowStatementHistoryQuarterly { get; set; }
    public Earnings1 earnings { get; set; }
    public Financialdata financialData { get; set; }
}

public class Assetprofile
{
    public string address1 { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }
    public string country { get; set; }
    public string phone { get; set; }
    public string website { get; set; }
    public string industry { get; set; }
    public string sector { get; set; }
    public string longBusinessSummary { get; set; }
    public int fullTimeEmployees { get; set; }
    public Companyofficer[] companyOfficers { get; set; }
    public int auditRisk { get; set; }
    public int boardRisk { get; set; }
    public int compensationRisk { get; set; }
    public int shareHolderRightsRisk { get; set; }
    public int overallRisk { get; set; }
    public int governanceEpochDate { get; set; }
    public int compensationAsOfEpochDate { get; set; }
    public int maxAge { get; set; }
}

public class Companyofficer
{
    public int maxAge { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public string title { get; set; }
    public int yearBorn { get; set; }
    public int fiscalYear { get; set; }
    public Totalpay totalPay { get; set; }
    public Exercisedvalue exercisedValue { get; set; }
    public Unexercisedvalue unexercisedValue { get; set; }
}

public class Totalpay
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Exercisedvalue
{
    public int raw { get; set; }
    public object fmt { get; set; }
    public string longFmt { get; set; }
}

public class Unexercisedvalue
{
    public int raw { get; set; }
    public object fmt { get; set; }
    public string longFmt { get; set; }
}

public class Recommendationtrend
{
    public Trend[] trend { get; set; }
    public int maxAge { get; set; }
}

public class Trend
{
    public string period { get; set; }
    public int strongBuy { get; set; }
    public int buy { get; set; }
    public int hold { get; set; }
    public int sell { get; set; }
    public int strongSell { get; set; }
}

public class Cashflowstatementhistory
{
    public Cashflowstatement[] cashflowStatements { get; set; }
    public int maxAge { get; set; }
}

public class Cashflowstatement
{
    public int maxAge { get; set; }
    public Enddate endDate { get; set; }
    public Netincome netIncome { get; set; }
    public Depreciation depreciation { get; set; }
    public Changetonetincome changeToNetincome { get; set; }
    public Changetoaccountreceivables changeToAccountReceivables { get; set; }
    public Changetoliabilities changeToLiabilities { get; set; }
    public Changetoinventory changeToInventory { get; set; }
    public Changetooperatingactivities changeToOperatingActivities { get; set; }
    public Totalcashfromoperatingactivities totalCashFromOperatingActivities { get; set; }
    public Capitalexpenditures capitalExpenditures { get; set; }
    public Investments investments { get; set; }
    public Othercashflowsfrominvestingactivities otherCashflowsFromInvestingActivities { get; set; }
    public Totalcashflowsfrominvestingactivities totalCashflowsFromInvestingActivities { get; set; }
    public Dividendspaid dividendsPaid { get; set; }
    public Netborrowings netBorrowings { get; set; }
    public Othercashflowsfromfinancingactivities otherCashflowsFromFinancingActivities { get; set; }
    public Totalcashfromfinancingactivities totalCashFromFinancingActivities { get; set; }
    public Changeincash changeInCash { get; set; }
    public Repurchaseofstock repurchaseOfStock { get; set; }
    public Issuanceofstock issuanceOfStock { get; set; }
}

public class Enddate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Netincome
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Depreciation
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetonetincome
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetoaccountreceivables
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetoliabilities
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetoinventory
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetooperatingactivities
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcashfromoperatingactivities
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Capitalexpenditures
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Investments
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Othercashflowsfrominvestingactivities
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcashflowsfrominvestingactivities
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Dividendspaid
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Netborrowings
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Othercashflowsfromfinancingactivities
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcashfromfinancingactivities
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changeincash
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Repurchaseofstock
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Issuanceofstock
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Indextrend
{
    public int maxAge { get; set; }
    public string symbol { get; set; }
    public Peratio peRatio { get; set; }
    public Pegratio pegRatio { get; set; }
    public Estimate[] estimates { get; set; }
}

public class Peratio
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Pegratio
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Estimate
{
    public string period { get; set; }
    public Growth growth { get; set; }
}

public class Growth
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Defaultkeystatistics
{
    public int maxAge { get; set; }
    public Pricehint priceHint { get; set; }
    public Enterprisevalue enterpriseValue { get; set; }
    public Forwardpe forwardPE { get; set; }
    public Profitmargins profitMargins { get; set; }
    public Floatshares floatShares { get; set; }
    public Sharesoutstanding sharesOutstanding { get; set; }
    public Sharesshort sharesShort { get; set; }
    public Sharesshortpriormonth sharesShortPriorMonth { get; set; }
    public Sharesshortpreviousmonthdate sharesShortPreviousMonthDate { get; set; }
    public Dateshortinterest dateShortInterest { get; set; }
    public Sharespercentsharesout sharesPercentSharesOut { get; set; }
    public Heldpercentinsiders heldPercentInsiders { get; set; }
    public Heldpercentinstitutions heldPercentInstitutions { get; set; }
    public Shortratio shortRatio { get; set; }
    public Shortpercentoffloat shortPercentOfFloat { get; set; }
    public Beta beta { get; set; }
    public Impliedsharesoutstanding impliedSharesOutstanding { get; set; }
    public Morningstaroverallrating morningStarOverallRating { get; set; }
    public Morningstarriskrating morningStarRiskRating { get; set; }
    public object category { get; set; }
    public Bookvalue bookValue { get; set; }
    public Pricetobook priceToBook { get; set; }
    public Annualreportexpenseratio annualReportExpenseRatio { get; set; }
    public Ytdreturn ytdReturn { get; set; }
    public Beta3year beta3Year { get; set; }
    public Totalassets totalAssets { get; set; }
    public Yield yield { get; set; }
    public object fundFamily { get; set; }
    public Fundinceptiondate fundInceptionDate { get; set; }
    public object legalType { get; set; }
    public Threeyearaveragereturn threeYearAverageReturn { get; set; }
    public Fiveyearaveragereturn fiveYearAverageReturn { get; set; }
    public Pricetosalestrailing12months priceToSalesTrailing12Months { get; set; }
    public Lastfiscalyearend lastFiscalYearEnd { get; set; }
    public Nextfiscalyearend nextFiscalYearEnd { get; set; }
    public Mostrecentquarter mostRecentQuarter { get; set; }
    public Earningsquarterlygrowth earningsQuarterlyGrowth { get; set; }
    public Revenuequarterlygrowth revenueQuarterlyGrowth { get; set; }
    public Netincometocommon netIncomeToCommon { get; set; }
    public Trailingeps trailingEps { get; set; }
    public Forwardeps forwardEps { get; set; }
    public Pegratio1 pegRatio { get; set; }
    public string lastSplitFactor { get; set; }
    public Lastsplitdate lastSplitDate { get; set; }
    public Enterprisetorevenue enterpriseToRevenue { get; set; }
    public Enterprisetoebitda enterpriseToEbitda { get; set; }
    public _52Weekchange _52WeekChange { get; set; }
    public Sandp52weekchange SandP52WeekChange { get; set; }
    public Lastdividendvalue lastDividendValue { get; set; }
    public Lastdividenddate lastDividendDate { get; set; }
    public Lastcapgain lastCapGain { get; set; }
    public Annualholdingsturnover annualHoldingsTurnover { get; set; }
}

public class Pricehint
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Enterprisevalue
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Forwardpe
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Profitmargins
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Floatshares
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Sharesoutstanding
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Sharesshort
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Sharesshortpriormonth
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Sharesshortpreviousmonthdate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Dateshortinterest
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Sharespercentsharesout
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Heldpercentinsiders
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Heldpercentinstitutions
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Shortratio
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Shortpercentoffloat
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Beta
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Impliedsharesoutstanding
{
    public int raw { get; set; }
    public object fmt { get; set; }
    public string longFmt { get; set; }
}

public class Morningstaroverallrating
{
}

public class Morningstarriskrating
{
}

public class Bookvalue
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Pricetobook
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Annualreportexpenseratio
{
}

public class Ytdreturn
{
}

public class Beta3year
{
}

public class Totalassets
{
}

public class Yield
{
}

public class Fundinceptiondate
{
}

public class Threeyearaveragereturn
{
}

public class Fiveyearaveragereturn
{
}

public class Pricetosalestrailing12months
{
}

public class Lastfiscalyearend
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Nextfiscalyearend
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Mostrecentquarter
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Earningsquarterlygrowth
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Revenuequarterlygrowth
{
}

public class Netincometocommon
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Trailingeps
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Forwardeps
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Pegratio1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Lastsplitdate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Enterprisetorevenue
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Enterprisetoebitda
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class _52Weekchange
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Sandp52weekchange
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Lastdividendvalue
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Lastdividenddate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Lastcapgain
{
}

public class Annualholdingsturnover
{
}

public class Industrytrend
{
    public int maxAge { get; set; }
    public object symbol { get; set; }
    public Peratio1 peRatio { get; set; }
    public Pegratio2 pegRatio { get; set; }
    public object[] estimates { get; set; }
}

public class Peratio1
{
}

public class Pegratio2
{
}

public class Incomestatementhistory
{
    public Incomestatementhistory1[] incomeStatementHistory { get; set; }
    public int maxAge { get; set; }
}

public class Incomestatementhistory1
{
    public int maxAge { get; set; }
    public Enddate1 endDate { get; set; }
    public Totalrevenue totalRevenue { get; set; }
    public Costofrevenue costOfRevenue { get; set; }
    public Grossprofit grossProfit { get; set; }
    public Researchdevelopment researchDevelopment { get; set; }
    public Sellinggeneraladministrative sellingGeneralAdministrative { get; set; }
    public Nonrecurring nonRecurring { get; set; }
    public Otheroperatingexpenses otherOperatingExpenses { get; set; }
    public Totaloperatingexpenses totalOperatingExpenses { get; set; }
    public Operatingincome operatingIncome { get; set; }
    public Totalotherincomeexpensenet totalOtherIncomeExpenseNet { get; set; }
    public Ebit ebit { get; set; }
    public Interestexpense interestExpense { get; set; }
    public Incomebeforetax incomeBeforeTax { get; set; }
    public Incometaxexpense incomeTaxExpense { get; set; }
    public Minorityinterest minorityInterest { get; set; }
    public Netincomefromcontinuingops netIncomeFromContinuingOps { get; set; }
    public Discontinuedoperations discontinuedOperations { get; set; }
    public Extraordinaryitems extraordinaryItems { get; set; }
    public Effectofaccountingcharges effectOfAccountingCharges { get; set; }
    public Otheritems otherItems { get; set; }
    public Netincome1 netIncome { get; set; }
    public Netincomeapplicabletocommonshares netIncomeApplicableToCommonShares { get; set; }
}

public class Enddate1
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Totalrevenue
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Costofrevenue
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Grossprofit
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Researchdevelopment
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Sellinggeneraladministrative
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Nonrecurring
{
}

public class Otheroperatingexpenses
{
}

public class Totaloperatingexpenses
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Operatingincome
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalotherincomeexpensenet
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Ebit
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Interestexpense
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Incomebeforetax
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Incometaxexpense
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Minorityinterest
{
}

public class Netincomefromcontinuingops
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Discontinuedoperations
{
}

public class Extraordinaryitems
{
}

public class Effectofaccountingcharges
{
}

public class Otheritems
{
}

public class Netincome1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Netincomeapplicabletocommonshares
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Fundownership
{
    public int maxAge { get; set; }
    public Ownershiplist[] ownershipList { get; set; }
}

public class Ownershiplist
{
    public int maxAge { get; set; }
    public Reportdate reportDate { get; set; }
    public string organization { get; set; }
    public Pctheld pctHeld { get; set; }
    public Position position { get; set; }
    public Value value { get; set; }
    public Pctchange pctChange { get; set; }
}

public class Reportdate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Pctheld
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Position
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Value
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Pctchange
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Summarydetail
{
    public int maxAge { get; set; }
    public Pricehint1 priceHint { get; set; }
    public Previousclose previousClose { get; set; }
    public Open open { get; set; }
    public Daylow dayLow { get; set; }
    public Dayhigh dayHigh { get; set; }
    public Regularmarketpreviousclose regularMarketPreviousClose { get; set; }
    public Regularmarketopen regularMarketOpen { get; set; }
    public Regularmarketdaylow regularMarketDayLow { get; set; }
    public Regularmarketdayhigh regularMarketDayHigh { get; set; }
    public Dividendrate dividendRate { get; set; }
    public Dividendyield dividendYield { get; set; }
    public Exdividenddate exDividendDate { get; set; }
    public Payoutratio payoutRatio { get; set; }
    public Fiveyearavgdividendyield fiveYearAvgDividendYield { get; set; }
    public Beta1 beta { get; set; }
    public Trailingpe trailingPE { get; set; }
    public Forwardpe1 forwardPE { get; set; }
    public Volume volume { get; set; }
    public Regularmarketvolume regularMarketVolume { get; set; }
    public Averagevolume averageVolume { get; set; }
    public Averagevolume10days averageVolume10days { get; set; }
    public Averagedailyvolume10day averageDailyVolume10Day { get; set; }
    public Bid bid { get; set; }
    public Ask ask { get; set; }
    public Bidsize bidSize { get; set; }
    public Asksize askSize { get; set; }
    public Marketcap marketCap { get; set; }
    public Yield1 yield { get; set; }
    public Ytdreturn1 ytdReturn { get; set; }
    public Totalassets1 totalAssets { get; set; }
    public Expiredate expireDate { get; set; }
    public Strikeprice strikePrice { get; set; }
    public Openinterest openInterest { get; set; }
    public Fiftytwoweeklow fiftyTwoWeekLow { get; set; }
    public Fiftytwoweekhigh fiftyTwoWeekHigh { get; set; }
    public Pricetosalestrailing12months1 priceToSalesTrailing12Months { get; set; }
    public Fiftydayaverage fiftyDayAverage { get; set; }
    public Twohundreddayaverage twoHundredDayAverage { get; set; }
    public Trailingannualdividendrate trailingAnnualDividendRate { get; set; }
    public Trailingannualdividendyield trailingAnnualDividendYield { get; set; }
    public Navprice navPrice { get; set; }
    public string currency { get; set; }
    public object fromCurrency { get; set; }
    public object toCurrency { get; set; }
    public object lastMarket { get; set; }
    public object coinMarketCapLink { get; set; }
    public Volume24hr volume24Hr { get; set; }
    public Volumeallcurrencies volumeAllCurrencies { get; set; }
    public Circulatingsupply circulatingSupply { get; set; }
    public object algorithm { get; set; }
    public Maxsupply maxSupply { get; set; }
    public Startdate startDate { get; set; }
    public bool tradeable { get; set; }
}

public class Pricehint1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Previousclose
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Open
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Daylow
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Dayhigh
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketpreviousclose
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketopen
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketdaylow
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketdayhigh
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Dividendrate
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Dividendyield
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Exdividenddate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Payoutratio
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Fiveyearavgdividendyield
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Beta1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Trailingpe
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Forwardpe1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Volume
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Regularmarketvolume
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Averagevolume
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Averagevolume10days
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Averagedailyvolume10day
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Bid
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Ask
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Bidsize
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Asksize
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Marketcap
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Yield1
{
}

public class Ytdreturn1
{
}

public class Totalassets1
{
}

public class Expiredate
{
}

public class Strikeprice
{
}

public class Openinterest
{
}

public class Fiftytwoweeklow
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Fiftytwoweekhigh
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Pricetosalestrailing12months1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Fiftydayaverage
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Twohundreddayaverage
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Trailingannualdividendrate
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Trailingannualdividendyield
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Navprice
{
}

public class Volume24hr
{
}

public class Volumeallcurrencies
{
}

public class Circulatingsupply
{
}

public class Maxsupply
{
}

public class Startdate
{
}

public class Insiderholders
{
    public Holder[] holders { get; set; }
    public int maxAge { get; set; }
}

public class Holder
{
    public int maxAge { get; set; }
    public string name { get; set; }
    public string relation { get; set; }
    public string url { get; set; }
    public string transactionDescription { get; set; }
    public Latesttransdate latestTransDate { get; set; }
    public Positiondirect positionDirect { get; set; }
    public Positiondirectdate positionDirectDate { get; set; }
    public Positionindirect positionIndirect { get; set; }
    public Positionindirectdate positionIndirectDate { get; set; }
}

public class Latesttransdate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Positiondirect
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Positiondirectdate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Positionindirect
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Positionindirectdate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Calendarevents
{
    public int maxAge { get; set; }
    public Earnings earnings { get; set; }
    public Exdividenddate1 exDividendDate { get; set; }
    public Dividenddate dividendDate { get; set; }
}

public class Earnings
{
    public Earningsdate[] earningsDate { get; set; }
    public Earningsaverage earningsAverage { get; set; }
    public Earningslow earningsLow { get; set; }
    public Earningshigh earningsHigh { get; set; }
    public Revenueaverage revenueAverage { get; set; }
    public Revenuelow revenueLow { get; set; }
    public Revenuehigh revenueHigh { get; set; }
}

public class Earningsaverage
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Earningslow
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Earningshigh
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Revenueaverage
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Revenuelow
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Revenuehigh
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Earningsdate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Exdividenddate1
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Dividenddate
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Upgradedowngradehistory
{
    public History[] history { get; set; }
    public int maxAge { get; set; }
}

public class History
{
    public int epochGradeDate { get; set; }
    public string firm { get; set; }
    public string toGrade { get; set; }
    public string fromGrade { get; set; }
    public string action { get; set; }
}

public class Price
{
    public int maxAge { get; set; }
    public Premarketchange preMarketChange { get; set; }
    public Premarketprice preMarketPrice { get; set; }
    public string preMarketSource { get; set; }
    public Postmarketchangepercent postMarketChangePercent { get; set; }
    public Postmarketchange postMarketChange { get; set; }
    public int postMarketTime { get; set; }
    public Postmarketprice postMarketPrice { get; set; }
    public string postMarketSource { get; set; }
    public Regularmarketchangepercent regularMarketChangePercent { get; set; }
    public Regularmarketchange regularMarketChange { get; set; }
    public int regularMarketTime { get; set; }
    public Pricehint2 priceHint { get; set; }
    public Regularmarketprice regularMarketPrice { get; set; }
    public Regularmarketdayhigh1 regularMarketDayHigh { get; set; }
    public Regularmarketdaylow1 regularMarketDayLow { get; set; }
    public Regularmarketvolume1 regularMarketVolume { get; set; }
    public Averagedailyvolume10day1 averageDailyVolume10Day { get; set; }
    public Averagedailyvolume3month averageDailyVolume3Month { get; set; }
    public Regularmarketpreviousclose1 regularMarketPreviousClose { get; set; }
    public string regularMarketSource { get; set; }
    public Regularmarketopen1 regularMarketOpen { get; set; }
    public Strikeprice1 strikePrice { get; set; }
    public Openinterest1 openInterest { get; set; }
    public string exchange { get; set; }
    public string exchangeName { get; set; }
    public int exchangeDataDelayedBy { get; set; }
    public string marketState { get; set; }
    public string quoteType { get; set; }
    public string symbol { get; set; }
    public object underlyingSymbol { get; set; }
    public string shortName { get; set; }
    public string longName { get; set; }
    public string currency { get; set; }
    public string quoteSourceName { get; set; }
    public string currencySymbol { get; set; }
    public object fromCurrency { get; set; }
    public object toCurrency { get; set; }
    public object lastMarket { get; set; }
    public Volume24hr1 volume24Hr { get; set; }
    public Volumeallcurrencies1 volumeAllCurrencies { get; set; }
    public Circulatingsupply1 circulatingSupply { get; set; }
    public Marketcap1 marketCap { get; set; }
}

public class Premarketchange
{
}

public class Premarketprice
{
}

public class Postmarketchangepercent
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Postmarketchange
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Postmarketprice
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketchangepercent
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketchange
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Pricehint2
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Regularmarketprice
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketdayhigh1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketdaylow1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketvolume1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Averagedailyvolume10day1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Averagedailyvolume3month
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Regularmarketpreviousclose1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Regularmarketopen1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Strikeprice1
{
}

public class Openinterest1
{
}

public class Volume24hr1
{
}

public class Volumeallcurrencies1
{
}

public class Circulatingsupply1
{
}

public class Marketcap1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Balancesheethistory
{
    public Balancesheetstatement[] balanceSheetStatements { get; set; }
    public int maxAge { get; set; }
}

public class Balancesheetstatement
{
    public int maxAge { get; set; }
    public Enddate2 endDate { get; set; }
    public Cash cash { get; set; }
    public Shortterminvestments shortTermInvestments { get; set; }
    public Netreceivables netReceivables { get; set; }
    public Inventory inventory { get; set; }
    public Othercurrentassets otherCurrentAssets { get; set; }
    public Totalcurrentassets totalCurrentAssets { get; set; }
    public Longterminvestments longTermInvestments { get; set; }
    public Propertyplantequipment propertyPlantEquipment { get; set; }
    public Otherassets otherAssets { get; set; }
    public Totalassets2 totalAssets { get; set; }
    public Accountspayable accountsPayable { get; set; }
    public Shortlongtermdebt shortLongTermDebt { get; set; }
    public Othercurrentliab otherCurrentLiab { get; set; }
    public Longtermdebt longTermDebt { get; set; }
    public Otherliab otherLiab { get; set; }
    public Totalcurrentliabilities totalCurrentLiabilities { get; set; }
    public Totalliab totalLiab { get; set; }
    public Commonstock commonStock { get; set; }
    public Retainedearnings retainedEarnings { get; set; }
    public Treasurystock treasuryStock { get; set; }
    public Otherstockholderequity otherStockholderEquity { get; set; }
    public Totalstockholderequity totalStockholderEquity { get; set; }
    public Nettangibleassets netTangibleAssets { get; set; }
}

public class Enddate2
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Cash
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Shortterminvestments
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Netreceivables
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Inventory
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Othercurrentassets
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcurrentassets
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Longterminvestments
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Propertyplantequipment
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Otherassets
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalassets2
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Accountspayable
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Shortlongtermdebt
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Othercurrentliab
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Longtermdebt
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Otherliab
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcurrentliabilities
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalliab
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Commonstock
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Retainedearnings
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Treasurystock
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Otherstockholderequity
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalstockholderequity
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Nettangibleassets
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Earningstrend
{
    public Trend1[] trend { get; set; }
    public int maxAge { get; set; }
}

public class Trend1
{
    public int maxAge { get; set; }
    public string period { get; set; }
    public string endDate { get; set; }
    public Growth1 growth { get; set; }
    public Earningsestimate earningsEstimate { get; set; }
    public Revenueestimate revenueEstimate { get; set; }
    public Epstrend epsTrend { get; set; }
    public Epsrevisions epsRevisions { get; set; }
}

public class Growth1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Earningsestimate
{
    public Avg avg { get; set; }
    public Low low { get; set; }
    public High high { get; set; }
    public Yearagoeps yearAgoEps { get; set; }
    public Numberofanalysts numberOfAnalysts { get; set; }
    public Growth2 growth { get; set; }
}

public class Avg
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Low
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class High
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Yearagoeps
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Numberofanalysts
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Growth2
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Revenueestimate
{
    public Avg1 avg { get; set; }
    public Low1 low { get; set; }
    public High1 high { get; set; }
    public Numberofanalysts1 numberOfAnalysts { get; set; }
    public Yearagorevenue yearAgoRevenue { get; set; }
    public Growth3 growth { get; set; }
}

public class Avg1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Low1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class High1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Numberofanalysts1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Yearagorevenue
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Growth3
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Epstrend
{
    public Current current { get; set; }
    public _7Daysago _7daysAgo { get; set; }
    public _30Daysago _30daysAgo { get; set; }
    public _60Daysago _60daysAgo { get; set; }
    public _90Daysago _90daysAgo { get; set; }
}

public class Current
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class _7Daysago
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class _30Daysago
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class _60Daysago
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class _90Daysago
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Epsrevisions
{
    public Uplast7days upLast7days { get; set; }
    public Uplast30days upLast30days { get; set; }
    public Downlast30days downLast30days { get; set; }
    public Downlast90days downLast90days { get; set; }
}

public class Uplast7days
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Uplast30days
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Downlast30days
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Downlast90days
{
}

public class Secfilings
{
    public Filing[] filings { get; set; }
    public int maxAge { get; set; }
}

public class Filing
{
    public string date { get; set; }
    public int epochDate { get; set; }
    public string type { get; set; }
    public string title { get; set; }
    public string edgarUrl { get; set; }
    public int maxAge { get; set; }
}

public class Institutionownership
{
    public int maxAge { get; set; }
    public Ownershiplist1[] ownershipList { get; set; }
}

public class Ownershiplist1
{
    public int maxAge { get; set; }
    public Reportdate1 reportDate { get; set; }
    public string organization { get; set; }
    public Pctheld1 pctHeld { get; set; }
    public Position1 position { get; set; }
    public Value1 value { get; set; }
    public Pctchange1 pctChange { get; set; }
}

public class Reportdate1
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Pctheld1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Position1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Value1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Pctchange1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Majorholdersbreakdown
{
    public int maxAge { get; set; }
    public Insiderspercentheld insidersPercentHeld { get; set; }
    public Institutionspercentheld institutionsPercentHeld { get; set; }
    public Institutionsfloatpercentheld institutionsFloatPercentHeld { get; set; }
    public Institutionscount institutionsCount { get; set; }
}

public class Insiderspercentheld
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Institutionspercentheld
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Institutionsfloatpercentheld
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Institutionscount
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Balancesheethistoryquarterly
{
    public Balancesheetstatement1[] balanceSheetStatements { get; set; }
    public int maxAge { get; set; }
}

public class Balancesheetstatement1
{
    public int maxAge { get; set; }
    public Enddate3 endDate { get; set; }
    public Cash1 cash { get; set; }
    public Shortterminvestments1 shortTermInvestments { get; set; }
    public Netreceivables1 netReceivables { get; set; }
    public Inventory1 inventory { get; set; }
    public Othercurrentassets1 otherCurrentAssets { get; set; }
    public Totalcurrentassets1 totalCurrentAssets { get; set; }
    public Longterminvestments1 longTermInvestments { get; set; }
    public Propertyplantequipment1 propertyPlantEquipment { get; set; }
    public Otherassets1 otherAssets { get; set; }
    public Totalassets3 totalAssets { get; set; }
    public Accountspayable1 accountsPayable { get; set; }
    public Shortlongtermdebt1 shortLongTermDebt { get; set; }
    public Othercurrentliab1 otherCurrentLiab { get; set; }
    public Longtermdebt1 longTermDebt { get; set; }
    public Otherliab1 otherLiab { get; set; }
    public Totalcurrentliabilities1 totalCurrentLiabilities { get; set; }
    public Totalliab1 totalLiab { get; set; }
    public Commonstock1 commonStock { get; set; }
    public Retainedearnings1 retainedEarnings { get; set; }
    public Treasurystock1 treasuryStock { get; set; }
    public Otherstockholderequity1 otherStockholderEquity { get; set; }
    public Totalstockholderequity1 totalStockholderEquity { get; set; }
    public Nettangibleassets1 netTangibleAssets { get; set; }
}

public class Enddate3
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Cash1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Shortterminvestments1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Netreceivables1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Inventory1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Othercurrentassets1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcurrentassets1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Longterminvestments1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Propertyplantequipment1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Otherassets1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalassets3
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Accountspayable1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Shortlongtermdebt1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Othercurrentliab1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Longtermdebt1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Otherliab1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcurrentliabilities1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalliab1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Commonstock1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Retainedearnings1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Treasurystock1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Otherstockholderequity1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalstockholderequity1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Nettangibleassets1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Earningshistory
{
    public History1[] history { get; set; }
    public int maxAge { get; set; }
}

public class History1
{
    public int maxAge { get; set; }
    public Epsactual epsActual { get; set; }
    public Epsestimate epsEstimate { get; set; }
    public Epsdifference epsDifference { get; set; }
    public Surprisepercent surprisePercent { get; set; }
    public Quarter quarter { get; set; }
    public string period { get; set; }
}

public class Epsactual
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Epsestimate
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Epsdifference
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Surprisepercent
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Quarter
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Majordirectholders
{
    public object[] holders { get; set; }
    public int maxAge { get; set; }
}

public class Esgscores
{
    public int maxAge { get; set; }
    public Totalesg totalEsg { get; set; }
    public Environmentscore environmentScore { get; set; }
    public Socialscore socialScore { get; set; }
    public Governancescore governanceScore { get; set; }
    public int ratingYear { get; set; }
    public int ratingMonth { get; set; }
    public float highestControversy { get; set; }
    public int peerCount { get; set; }
    public string esgPerformance { get; set; }
    public string peerGroup { get; set; }
    public string[] relatedControversy { get; set; }
    public Peeresgscoreperformance peerEsgScorePerformance { get; set; }
    public Peergovernanceperformance peerGovernancePerformance { get; set; }
    public Peersocialperformance peerSocialPerformance { get; set; }
    public Peerenvironmentperformance peerEnvironmentPerformance { get; set; }
    public Peerhighestcontroversyperformance peerHighestControversyPerformance { get; set; }
    public Percentile percentile { get; set; }
    public object environmentPercentile { get; set; }
    public object socialPercentile { get; set; }
    public object governancePercentile { get; set; }
    public bool adult { get; set; }
    public bool alcoholic { get; set; }
    public bool animalTesting { get; set; }
    public bool catholic { get; set; }
    public bool controversialWeapons { get; set; }
    public bool smallArms { get; set; }
    public bool furLeather { get; set; }
    public bool gambling { get; set; }
    public bool gmo { get; set; }
    public bool militaryContract { get; set; }
    public bool nuclear { get; set; }
    public bool pesticides { get; set; }
    public bool palmOil { get; set; }
    public bool coal { get; set; }
    public bool tobacco { get; set; }
}

public class Totalesg
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Environmentscore
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Socialscore
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Governancescore
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Peeresgscoreperformance
{
    public float min { get; set; }
    public float avg { get; set; }
    public float max { get; set; }
}

public class Peergovernanceperformance
{
    public float min { get; set; }
    public float avg { get; set; }
    public float max { get; set; }
}

public class Peersocialperformance
{
    public float min { get; set; }
    public float avg { get; set; }
    public float max { get; set; }
}

public class Peerenvironmentperformance
{
    public float min { get; set; }
    public float avg { get; set; }
    public float max { get; set; }
}

public class Peerhighestcontroversyperformance
{
    public float min { get; set; }
    public float avg { get; set; }
    public float max { get; set; }
}

public class Percentile
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Summaryprofile
{
    public string address1 { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }
    public string country { get; set; }
    public string phone { get; set; }
    public string website { get; set; }
    public string industry { get; set; }
    public string sector { get; set; }
    public string longBusinessSummary { get; set; }
    public int fullTimeEmployees { get; set; }
    public object[] companyOfficers { get; set; }
    public int maxAge { get; set; }
}

public class Netsharepurchaseactivity
{
    public int maxAge { get; set; }
    public string period { get; set; }
    public Buyinfocount buyInfoCount { get; set; }
    public Buyinfoshares buyInfoShares { get; set; }
    public Buypercentinsidershares buyPercentInsiderShares { get; set; }
    public Sellinfocount sellInfoCount { get; set; }
    public Sellinfoshares sellInfoShares { get; set; }
    public Sellpercentinsidershares sellPercentInsiderShares { get; set; }
    public Netinfocount netInfoCount { get; set; }
    public Netinfoshares netInfoShares { get; set; }
    public Netpercentinsidershares netPercentInsiderShares { get; set; }
    public Totalinsidershares totalInsiderShares { get; set; }
}

public class Buyinfocount
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Buyinfoshares
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Buypercentinsidershares
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Sellinfocount
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Sellinfoshares
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Sellpercentinsidershares
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Netinfocount
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Netinfoshares
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Netpercentinsidershares
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Totalinsidershares
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Insidertransactions
{
    public Transaction[] transactions { get; set; }
    public int maxAge { get; set; }
}

public class Transaction
{
    public int maxAge { get; set; }
    public Shares shares { get; set; }
    public Value2 value { get; set; }
    public string filerUrl { get; set; }
    public string transactionText { get; set; }
    public string filerName { get; set; }
    public string filerRelation { get; set; }
    public string moneyText { get; set; }
    public Startdate1 startDate { get; set; }
    public string ownership { get; set; }
}

public class Shares
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Value2
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Startdate1
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Sectortrend
{
    public int maxAge { get; set; }
    public object symbol { get; set; }
    public Peratio2 peRatio { get; set; }
    public Pegratio3 pegRatio { get; set; }
    public object[] estimates { get; set; }
}

public class Peratio2
{
}

public class Pegratio3
{
}

public class Incomestatementhistoryquarterly
{
    public Incomestatementhistory2[] incomeStatementHistory { get; set; }
    public int maxAge { get; set; }
}

public class Incomestatementhistory2
{
    public int maxAge { get; set; }
    public Enddate4 endDate { get; set; }
    public Totalrevenue1 totalRevenue { get; set; }
    public Costofrevenue1 costOfRevenue { get; set; }
    public Grossprofit1 grossProfit { get; set; }
    public Researchdevelopment1 researchDevelopment { get; set; }
    public Sellinggeneraladministrative1 sellingGeneralAdministrative { get; set; }
    public Nonrecurring1 nonRecurring { get; set; }
    public Otheroperatingexpenses1 otherOperatingExpenses { get; set; }
    public Totaloperatingexpenses1 totalOperatingExpenses { get; set; }
    public Operatingincome1 operatingIncome { get; set; }
    public Totalotherincomeexpensenet1 totalOtherIncomeExpenseNet { get; set; }
    public Ebit1 ebit { get; set; }
    public Interestexpense1 interestExpense { get; set; }
    public Incomebeforetax1 incomeBeforeTax { get; set; }
    public Incometaxexpense1 incomeTaxExpense { get; set; }
    public Minorityinterest1 minorityInterest { get; set; }
    public Netincomefromcontinuingops1 netIncomeFromContinuingOps { get; set; }
    public Discontinuedoperations1 discontinuedOperations { get; set; }
    public Extraordinaryitems1 extraordinaryItems { get; set; }
    public Effectofaccountingcharges1 effectOfAccountingCharges { get; set; }
    public Otheritems1 otherItems { get; set; }
    public Netincome2 netIncome { get; set; }
    public Netincomeapplicabletocommonshares1 netIncomeApplicableToCommonShares { get; set; }
}

public class Enddate4
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Totalrevenue1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Costofrevenue1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Grossprofit1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Researchdevelopment1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Sellinggeneraladministrative1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Nonrecurring1
{
}

public class Otheroperatingexpenses1
{
}

public class Totaloperatingexpenses1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Operatingincome1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalotherincomeexpensenet1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Ebit1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Interestexpense1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Incomebeforetax1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Incometaxexpense1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Minorityinterest1
{
}

public class Netincomefromcontinuingops1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Discontinuedoperations1
{
}

public class Extraordinaryitems1
{
}

public class Effectofaccountingcharges1
{
}

public class Otheritems1
{
}

public class Netincome2
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Netincomeapplicabletocommonshares1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Cashflowstatementhistoryquarterly
{
    public Cashflowstatement1[] cashflowStatements { get; set; }
    public int maxAge { get; set; }
}

public class Cashflowstatement1
{
    public int maxAge { get; set; }
    public Enddate5 endDate { get; set; }
    public Netincome3 netIncome { get; set; }
    public Depreciation1 depreciation { get; set; }
    public Changetonetincome1 changeToNetincome { get; set; }
    public Changetoaccountreceivables1 changeToAccountReceivables { get; set; }
    public Changetoliabilities1 changeToLiabilities { get; set; }
    public Changetoinventory1 changeToInventory { get; set; }
    public Changetooperatingactivities1 changeToOperatingActivities { get; set; }
    public Totalcashfromoperatingactivities1 totalCashFromOperatingActivities { get; set; }
    public Capitalexpenditures1 capitalExpenditures { get; set; }
    public Investments1 investments { get; set; }
    public Othercashflowsfrominvestingactivities1 otherCashflowsFromInvestingActivities { get; set; }
    public Totalcashflowsfrominvestingactivities1 totalCashflowsFromInvestingActivities { get; set; }
    public Dividendspaid1 dividendsPaid { get; set; }
    public Netborrowings1 netBorrowings { get; set; }
    public Othercashflowsfromfinancingactivities1 otherCashflowsFromFinancingActivities { get; set; }
    public Totalcashfromfinancingactivities1 totalCashFromFinancingActivities { get; set; }
    public Changeincash1 changeInCash { get; set; }
    public Repurchaseofstock1 repurchaseOfStock { get; set; }
}

public class Enddate5
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Netincome3
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Depreciation1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetonetincome1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetoaccountreceivables1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetoliabilities1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetoinventory1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changetooperatingactivities1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcashfromoperatingactivities1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Capitalexpenditures1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Investments1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Othercashflowsfrominvestingactivities1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcashflowsfrominvestingactivities1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Dividendspaid1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Netborrowings1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Othercashflowsfromfinancingactivities1
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcashfromfinancingactivities1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Changeincash1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Repurchaseofstock1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Earnings1
{
    public int maxAge { get; set; }
    public Earningschart earningsChart { get; set; }
    public Financialschart financialsChart { get; set; }
    public string financialCurrency { get; set; }
}

public class Earningschart
{
    public Quarterly[] quarterly { get; set; }
    public Currentquarterestimate currentQuarterEstimate { get; set; }
    public string currentQuarterEstimateDate { get; set; }
    public int currentQuarterEstimateYear { get; set; }
    public Earningsdate1[] earningsDate { get; set; }
}

public class Currentquarterestimate
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Quarterly
{
    public string date { get; set; }
    public Actual actual { get; set; }
    public Estimate1 estimate { get; set; }
}

public class Actual
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Estimate1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Earningsdate1
{
    public int raw { get; set; }
    public string fmt { get; set; }
}

public class Financialschart
{
    public Yearly[] yearly { get; set; }
    public Quarterly1[] quarterly { get; set; }
}

public class Yearly
{
    public int date { get; set; }
    public Revenue revenue { get; set; }
    public Earnings2 earnings { get; set; }
}

public class Revenue
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Earnings2
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Quarterly1
{
    public string date { get; set; }
    public Revenue1 revenue { get; set; }
    public Earnings3 earnings { get; set; }
}

public class Revenue1
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Earnings3
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Financialdata
{
    public int maxAge { get; set; }
    public Currentprice currentPrice { get; set; }
    public Targethighprice targetHighPrice { get; set; }
    public Targetlowprice targetLowPrice { get; set; }
    public Targetmeanprice targetMeanPrice { get; set; }
    public Targetmedianprice targetMedianPrice { get; set; }
    public Recommendationmean recommendationMean { get; set; }
    public string recommendationKey { get; set; }
    public Numberofanalystopinions numberOfAnalystOpinions { get; set; }
    public Totalcash totalCash { get; set; }
    public Totalcashpershare totalCashPerShare { get; set; }
    public Ebitda ebitda { get; set; }
    public Totaldebt totalDebt { get; set; }
    public Quickratio quickRatio { get; set; }
    public Currentratio currentRatio { get; set; }
    public Totalrevenue2 totalRevenue { get; set; }
    public Debttoequity debtToEquity { get; set; }
    public Revenuepershare revenuePerShare { get; set; }
    public Returnonassets returnOnAssets { get; set; }
    public Returnonequity returnOnEquity { get; set; }
    public Grossprofits grossProfits { get; set; }
    public Freecashflow freeCashflow { get; set; }
    public Operatingcashflow operatingCashflow { get; set; }
    public Earningsgrowth earningsGrowth { get; set; }
    public Revenuegrowth revenueGrowth { get; set; }
    public Grossmargins grossMargins { get; set; }
    public Ebitdamargins ebitdaMargins { get; set; }
    public Operatingmargins operatingMargins { get; set; }
    public Profitmargins1 profitMargins { get; set; }
    public string financialCurrency { get; set; }
}

public class Currentprice
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Targethighprice
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Targetlowprice
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Targetmeanprice
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Targetmedianprice
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Recommendationmean
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Numberofanalystopinions
{
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcash
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totalcashpershare
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Ebitda
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Totaldebt
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Quickratio
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Currentratio
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Totalrevenue2
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Debttoequity
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Revenuepershare
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Returnonassets
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Returnonequity
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Grossprofits
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Freecashflow
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Operatingcashflow
{
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
}

public class Earningsgrowth
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Revenuegrowth
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Grossmargins
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Ebitdamargins
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Operatingmargins
{
    public float raw { get; set; }
    public string fmt { get; set; }
}

public class Profitmargins1
{
    public float raw { get; set; }
    public string fmt { get; set; }
}
