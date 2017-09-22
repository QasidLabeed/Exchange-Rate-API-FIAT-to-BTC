using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Rate_FIAT_to_BTC
{
    class TickerValueBtc
    {
        public string CallApi()
        {
            string cur;
            Console.WriteLine("Enter Currency \n" + "Options USD ,AUD,BRL,CAD,CHF,CLP,CNY,DKK,EUR,GBP,HKD,INR,ISK,JPY,KRW,NZD,PLN,SEK,SGD,THB,TWD");
            cur = Console.ReadLine();
            string url = "https://blockchain.info/ticker";
            Api api = new Api();
            var ApiResult = api.CallApi(url, cur);
            Currency CR = new Currency(api.GetJsonObj(ApiResult), cur);
            //CR.FifteenMin = Convert.ToDouble(api.GetStringResult(ApiResult,cur,"15m"));
            return "15m :" + CR.FifteenMin + " || Last:" + CR.Last + " || Buy :" + CR.Buy + " || Sell :" + CR.Sell + " || Sysmbol :" + CR.Symbol;
        }
    }
}
