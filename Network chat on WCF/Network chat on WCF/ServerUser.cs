using System.ServiceModel;

namespace Network_chat_on_WCF
{
	public class ServerUser
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public OperationContext operationContext { get; set; }

	}
}
