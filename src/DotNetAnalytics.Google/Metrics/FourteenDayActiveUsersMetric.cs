namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Total number of 14-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date,
    ///     or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value
    ///     will be the total unique users for the 14 day period ending on the given date.
    /// </summary>
    public class FourteenDayActiveUsersMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="FourteenDayActiveUsersMetric" />.
        /// </summary>
        public FourteenDayActiveUsersMetric()
            : base(
                "14 Day Active Users",
                "Total number of 14-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date.",
                false, "ga:14dayUsers")
        {
        }
    }
}