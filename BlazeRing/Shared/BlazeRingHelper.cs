using PoseidonSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BlazeRing.Shared
{
    public static class BlazeRingHelper
    {
        public static async Task<string> GetApiKeyEDDSASig(string signedEcdsaMessage, string address, int accountId)
        {
            var _keyDeets = await Task.Run(() => PoseidonHelper.GetL2PKFromMetaMask(signedEcdsaMessage, address));
            string _api_signatureBase = "GET&https%3A%2F%2Fapi3.loopring.io%2Fapi%2Fv3%2FapiKey&accountId%3D" + accountId;
            BigInteger _sigbaseToBitInt = SHA256Helper.CalculateSHA256HashNumber(_api_signatureBase);
            Eddsa eddsa = new Eddsa(_sigbaseToBitInt, _keyDeets.secretKey); //Put in the calculated poseidon hash in order to Sign
            return await Task.Run(() => eddsa.Sign());
        }
    }
}
