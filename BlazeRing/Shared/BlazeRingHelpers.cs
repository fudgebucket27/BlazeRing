using PoseidonSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BlazeRing.Shared
{
    public static class BlazeRingHelpers
    {
        public static string GetApiKeyEDDSASig(string _signedEcDSA, string address, int accountId)
        {
            var _keyDeets = PoseidonHelper.GetL2PKFromMetaMask(_signedEcDSA, address);

            string _api_signatureBase = "GET&https%3A%2F%2Fapi3.loopring.io%2Fapi%2Fv3%2FapiKey&accountId%3D" + accountId;
            BigInteger _sigbaseToBitInt = SHA256Helper.CalculateSHA256HashNumber(_api_signatureBase);
            Eddsa eddsa = new Eddsa(_sigbaseToBitInt, _keyDeets.secretKey); //Put in the calculated poseidon hash in order to Sign
            string signedMessage = eddsa.Sign();

            return signedMessage;
        }
    }
}
