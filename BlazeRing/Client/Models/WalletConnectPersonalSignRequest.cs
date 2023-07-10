using WalletConnectSharp.Common.Utils;
using WalletConnectSharp.Network.Models;

namespace BlazeRing.Client.Models
{
    [RpcMethod("personal_sign")]
    public class WalletConnectPersonalSignRequest
    {
        public string message { get; set; }
        public string account { get; set; }

        public WalletConnectPersonalSignRequest(string message, string account)
        {
            this.message = message;
            this.account = account;
        }
    }
}
