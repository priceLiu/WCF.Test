using System.Collections.Generic;
using System.ServiceModel;


namespace WCFStyle
{

	[ServiceContract]
	public interface ILog
	{
		[OperationContract]
		string GetAll();

	}
}
