using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.")]
	public class SearchGoal4ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchGoal4ConversionRate" />.
		/// </summary>
		public SearchGoal4ConversionRate(): base("Site Search Goal 4 Conversion Rate",false,"ga:searchGoal4ConversionRate")
		{
			
		}
	}
}

