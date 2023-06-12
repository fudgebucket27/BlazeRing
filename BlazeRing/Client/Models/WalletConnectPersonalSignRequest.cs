using WalletConnectSharp.Common.Utils;
using WalletConnectSharp.Network.Models;

namespace BlazeRing.Client.Models
{
    [RpcMethod("personal_sign"), RpcRequestOptions(Clock.ONE_MINUTE, 99998)]
    public class WalletConnectPersonalSignRequest
    {
        public string message { get; set; }
        public string address { get; set; }
    }
}
