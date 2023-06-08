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

        public async Task<string> GetAccountAddress()
        {
            return await _jsRuntime.InvokeAsync<string>("ethereumInterop.getAccount");
        }

        public async Task<string> SignMessage(string message)
        {
            return await _jsRuntime.InvokeAsync<string>("ethereumInterop.signMessage", message);
        }
    }
}
