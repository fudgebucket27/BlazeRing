using WalletConnectSharp.Common.Utils;
using WalletConnectSharp.Network.Models;

namespace BlazeRing.Client.Models
{
    [RpcMethod("personal_sign"), RpcRequestOptions(Clock.ONE_MINUTE, 99999)]
    public class PersonalSign : List<string>
    {
        public PersonalSign(params string[] personalSignParams)
            : base(personalSignParams) { }
    }
}
