using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Rate_FIAT_to_BTC
{
    class Currency
    {
        public Currency(JObject JObj,string curr)
        {
            fifteenMin = Convert.ToDouble(JObj[curr]["15m"]);
            cur = curr;
            last = Convert.ToDouble(JObj[curr]["last"]);
            buy = Convert.ToDouble(JObj[curr]["buy"]);
            sell = Convert.ToDouble(JObj[curr]["sell"]);
            symbol = Convert.ToString(JObj[curr]["symbol"]);
        }

        private string cur;

        public string Cur
        {
            get { return cur; }
            set { cur = value; }
        }

        private double  fifteenMin;

        public double  FifteenMin
        {
            get { return fifteenMin; }
            set { fifteenMin = value; }
        }

        private double last;

        public double  Last
        {
            get { return last; }
            set { last = value; }
        }

        private double  buy;

        public double  Buy
        {
            get { return buy; }
            set { buy = value; }
        }

        private double sell;

        public double Sell
        {
            get { return sell; }
            set { sell = value; }
        }

        private string symbol;

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }



    }
}
