using WalletConnectSharp.Network.Models;

namespace BlazeRing.Client.Models
{
    [RpcMethod("personal_sign")]
    public class WalletConnectPersonalSignRequest
    {
        public string message { get; set; }
        public string address { get; set; }
        public WalletConnectPersonalSignRequest(string message, string address)
        {
            this.message = message;
            this.address = address;
        }
    }
}
