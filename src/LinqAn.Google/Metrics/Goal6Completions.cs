using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of completions for the requested goal number.
	/// </summary>
	[Description("The total number of completions for the requested goal number.")]
	public class Goal6Completions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal6Completions" />.
		/// </summary>
		public Goal6Completions(): base("Goal 6 Completions",true,"ga:goal6Completions")
		{
			
		}
	}
}

