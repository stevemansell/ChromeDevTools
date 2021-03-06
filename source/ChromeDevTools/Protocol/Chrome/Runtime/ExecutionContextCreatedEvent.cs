using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Issued when new execution context is created.
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextCreated)]
	[SupportedBy("Chrome")]
	public class ExecutionContextCreatedEvent
	{
		/// <summary>
		/// Gets or sets A newly created execution contex.
		/// </summary>
		public ExecutionContextDescription Context { get; set; }
	}
}
