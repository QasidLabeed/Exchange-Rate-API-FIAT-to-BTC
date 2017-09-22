using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Rate_FIAT_to_BTC
{
    class Program
    {
        static void Main(string[] args)
        {
            //To Get Currency Values
            TickerValueBtc tickerValueBtc = new TickerValueBtc();

            //var response =tickerValueBtc.CallApi();
            //Console.WriteLine(response);

            // TO get Currency Converstion to BTC Uncomment the code
            BtcConversion bitConversion = new BtcConversion();
            var result =bitConversion.CallApi();
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
