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
        public static async Task<string> GenerateXApiSigHeader(string signedEcdsaMessage, string address, int accountId)
        {
            var keyDetails = await Task.Run(() => LoopringL2KeyGenerator.GenerateL2KeyDetails(signedEcdsaMessage, address, true));
            string signatureBase = "GET&https%3A%2F%2Fapi3.loopring.io%2Fapi%2Fv3%2FapiKey&accountId%3D" + accountId;
            BigInteger signatureBigInt = SHA256Helper.CalculateSHA256HashNumber(signatureBase);
            Eddsa eddsa = new Eddsa(signatureBigInt, keyDetails.secretKey);
            return await Task.Run(() => eddsa.Sign());
        }

        public static string StringToHex(string input)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(input);
            StringBuilder hex = new StringBuilder(byteArray.Length * 2);
            foreach (byte b in byteArray)
                hex.AppendFormat("{0:x2}", b);
            return "0x" + hex.ToString();
        }
    }
}
