using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Collection entry.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CollectionEntry
	{
		/// <summary>
		/// Gets or sets Entry key of a map-like collection, otherwise not provided.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Gets or sets Entry value.
		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
