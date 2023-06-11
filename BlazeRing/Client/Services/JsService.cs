using System.Threading.Tasks;
using Microsoft.JSInterop;
namespace BlazeRing.Client.Services
{
    public class JsService
    {
        private readonly IJSRuntime _jsRuntime;

        public JsService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<string> GetBrowserWalletAccount()
        {
            return await _jsRuntime.InvokeAsync<string>("ethereumInterop.getAccount");
        }

        public async Task<string> SignMessageBrowserWallet(string message)
        {
            return await _jsRuntime.InvokeAsync<string>("ethereumInterop.signMessage", message);
        }
    }
}
