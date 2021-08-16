using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfLibr
{
    [ServiceContract]
    public interface ITransferObject
    {
        [OperationContract]
        string GetProxiByKey(string key);
    }
}
