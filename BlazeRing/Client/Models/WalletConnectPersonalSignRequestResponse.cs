using WalletConnectSharp.Common.Utils;
using WalletConnectSharp.Network.Models;

namespace BlazeRing.Client.Models
{
    [RpcResponseOptions(Clock.ONE_MINUTE, 99999)]
    public class WalletConnectPersonalSignRequestResponse
    {
        public string result { get; set; }
    }
}
