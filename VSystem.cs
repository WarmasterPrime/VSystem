using System;
using System.Management;

namespace VSystem
{
	/// <summary>
	/// Manages system information and queries.
	/// </summary>
	public class VSystem
	{
		/// <summary>
		/// The searcher object instance.
		/// </summary>
		protected static ManagementObjectSearcher Searcher=new ManagementObjectSearcher();


		/// <inheritdoc cref="Get(ObjectQuery)"/>
		public static ManagementObjectCollection Get(string query) => Get(new ObjectQuery(query));
		/// <summary>
		/// Processes the search query.
		/// </summary>
		/// <param name="query">The search query to process on the system.</param>
		/// <returns>a <see cref="ManagementObjectCollection"/> consisting of the results from the query.</returns>
		public static ManagementObjectCollection Get(ObjectQuery query)
		{
			Searcher.Query=query;
			return Searcher.Get();
		}

	}
}