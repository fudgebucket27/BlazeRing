using System.Threading.Tasks;
using Microsoft.JSInterop;
namespace BlazeRing.Client.Services
{
    public class EthereumService
    {
        private readonly IJSRuntime _jsRuntime;

        public EthereumService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public ValueTask<string> GetAccountAddress()
        {
            return _jsRuntime.InvokeAsync<string>("ethereumInterop.getAccount");
        }
    }
}
