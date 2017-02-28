using System.Security.Cryptography;
using System.Text;

namespace SherEShop.Utilities
{
    public static class ExtensionCandies
    {
        public static string ToMD5(this string input)
        {
            return MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input)).ToString();
        }
    }
}