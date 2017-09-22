using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Rate_FIAT_to_BTC
{
    class BtcConversion
    {
        public string CallApi()
        {
            Console.WriteLine("Enter Currecy to convert to BTC");
            string curr = Console.ReadLine();
            Console.WriteLine("Enter Value to be converted");
            string amount = Console.ReadLine();

            string[] Param = { curr, amount };
            string conv = "https://blockchain.info/tobtc?currency=" + Param[0] + "&value=" + Param[1];
            Api ToBtc = new Api();
            var response= ToBtc.CallApi(conv);
            return amount + " " + curr + " in BTC = " + response;
        }
        
    }
}
