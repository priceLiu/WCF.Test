using System.Collections.Generic;
using System.ServiceModel;


namespace CN100WCF
{

    [ServiceContract(Name = "WCFTest", Namespace = "http://test.cn100.com/")]
	public interface ILog
	{
		[OperationContract]
		string GetAll();

	}
}
