using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfLibr
{
    public class Transfer : ITransferObject
    {
        public string GetProxiByKey(string key)
        {
            string result = "Error";

            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("zaz", "192.168.0.1:80");
            dict.Add("gaz", "192.168.0.1:85");
            dict.Add("almaz", "192.168.0.1:808");

            bool IsPresent = dict.TryGetValue(key, out result);

            if(!IsPresent)
            {
                result = "Error Key!";
            }


            return result;
        }
    }
}
