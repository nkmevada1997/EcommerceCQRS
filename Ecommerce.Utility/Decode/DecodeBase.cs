using System.Text;

namespace Ecommerce.Utility.Decode
{
    public class DecodeBase
    {
        public static string DecodeBase64(string value)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(value));
        }
    }
}
