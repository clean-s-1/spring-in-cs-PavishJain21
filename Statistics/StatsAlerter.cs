using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{

    
    public class StatsAlerter
    {
        private readonly double _maxThrasold;
        private readonly IAlerter[] _alerter;
        public StatsAlerter(double maxThrasold, IAlerter[] alerter )
        {
            _maxThrasold = maxThrasold;
            _alerter = alerter;
        }

        public void checkAndAlert(IList<double> list)
        {

        }
    }
}
