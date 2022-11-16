using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumApp1
{
    internal class TestAPI
    {
        private HttpClient _httpClient = new HttpClient();
        private string _uri = "https://api.publicapis.org";

        public async Task<string> testRequest()
        {
            var Builder = new UriBuilder($"{_uri}/entries?category=animals&HTTPS=true");
            var Response = await _httpClient.GetAsync(Builder.Uri);
            var Context = await Response.Content.ReadAsStringAsync();

            //return await _httpClient.GetStringAsync(_uri);
            return Context;
        }

        public async Task<string> StockRequest()
        {
            var Builder = new UriBuilder("https://query2.finance.yahoo.com/v10/finance/quoteSummary/" +
                "AAPL?modules=assetProfile%2CsummaryProfile%2CsummaryDetail%2CesgScores%2Cprice%2CincomeStatementHistory" +
                "%2CincomeStatementHistoryQuarterly%2CbalanceSheetHistory%2CbalanceSheetHistoryQuarterly%2CcashflowStatementHistory" +
                "%2CcashflowStatementHistoryQuarterly%2CdefaultKeyStatistics%2CfinancialData%2CcalendarEvents%2CsecFilings" +
                "%2CrecommendationTrend%2CupgradeDowngradeHistory%2CinstitutionOwnership%2CfundOwnership%2CmajorDirectHolders" +
                "%2CmajorHoldersBreakdown%2CinsiderTransactions%2CinsiderHolders%2CnetSharePurchaseActivity%2Cearnings%2CearningsHistory" +
                "%2CearningsTrend%2CindustryTrend%2CindexTrend%2CsectorTrend");
            var Response = await _httpClient.GetAsync(Builder.Uri);
            var Context = await Response.Content.ReadAsStringAsync();

            //return await _httpClient.GetStringAsync(_uri);
            return Context;
        }

    }

    public class SecondClass
    {
        public SecondClass()
        {

        }
    }
}
