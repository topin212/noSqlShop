using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.WebUtilities;

namespace SherEShop.Utilities
{
    public static class ExtensionCandies
    {
        public static string ToMD5(this string input)
        {
            return MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input)).ToString();
        }

        public static string base64Decode(this string input)
        {
            return Encoding.UTF8.GetChars(Base64UrlTextEncoder.Decode(input)).ToString();
        }

        public static string base64Encode(this string input)
        {
            return Base64UrlTextEncoder.Encode(Encoding.UTF8.GetBytes(input));
        }
    }
}