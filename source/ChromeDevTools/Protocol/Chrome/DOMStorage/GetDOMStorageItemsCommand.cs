using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Command(ProtocolName.DOMStorage.GetDOMStorageItems)]
	[SupportedBy("Chrome")]
	public class GetDOMStorageItemsCommand
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
