using WalletConnectSharp.Network.Models;

namespace BlazeRing.Client.Models
{
    [RpcMethod("personal_sign")]
    public class WalletConnectPersonalSignRequest
    {
        public string message { get; set; }
        public  WalletConnectPersonalSignRequest(string message)
        {
            this.message = message;
        }
}
